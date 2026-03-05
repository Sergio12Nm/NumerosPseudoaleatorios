using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Numeros_Pseudoaleatorios
{
    public class GraficosForm : Form
    {
        public GraficosForm(List<double> numeros, string titulo = "Gráficos")
        {
            this.Text = titulo;
            this.Size = new Size(800, 600);

            if (numeros == null) numeros = new List<double>();

            var split = new SplitContainer();
            split.Dock = DockStyle.Fill;
            split.Orientation = Orientation.Horizontal;
            split.SplitterDistance = this.ClientSize.Height / 2;
            this.Controls.Add(split);

            var pbLine = new PictureBox { Dock = DockStyle.Fill, BackColor = Color.White };
            var pbHist = new PictureBox { Dock = DockStyle.Fill, BackColor = Color.White };

            split.Panel1.Controls.Add(pbLine);
            split.Panel2.Controls.Add(pbHist);

            pbLine.Paint += (s, e) => DrawLinePlot(e.Graphics, pbLine.ClientRectangle, numeros);
            pbHist.Paint += (s, e) => DrawHistogram(e.Graphics, pbHist.ClientRectangle, numeros);

            // Force initial paint
            pbLine.Invalidate();
            pbHist.Invalidate();
        }

        private void DrawLinePlot(Graphics g, Rectangle rect, List<double> datos)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (datos == null || datos.Count == 0) return;

            int margin = 50;
            int w = rect.Width;
            int h = rect.Height;

            int plotW = w - 2 * margin;
            int plotH = h - 2 * margin;

            // Escala fija
            double min = 0.0;
            double max = 1.0;

            // Dibujar ejes
            g.DrawLine(Pens.Black, margin, h - margin, w - margin, h - margin); // X
            g.DrawLine(Pens.Black, margin, margin, margin, h - margin); // Y

            // Ticks eje Y (0 a 1)
            using (var f = new Font("Segoe UI", 8))
            {
                for (int i = 0; i <= 10; i++)
                {
                    float y = margin + i * plotH / 10f;
                    double value = max - i * (max - min) / 10;
                    g.DrawLine(Pens.Gray, margin - 5, y, margin, y);
                    g.DrawString(value.ToString("0.0"), f, Brushes.Black, 5, y - 6);
                }
            }

            // Dibujar línea
            for (int i = 0; i < datos.Count - 1; i++)
            {
                float x1 = margin + i * plotW / (float)Math.Max(1, datos.Count - 1);
                float y1 = margin + (float)((max - datos[i]) / (max - min)) * plotH;

                float x2 = margin + (i + 1) * plotW / (float)Math.Max(1, datos.Count - 1);
                float y2 = margin + (float)((max - datos[i + 1]) / (max - min)) * plotH;

                g.DrawLine(new Pen(Color.Blue, 1.5f), x1, y1, x2, y2);
            }

            // Línea de media
            double media = datos.Average();
            float yMedia = margin + (float)((max - media) / (max - min)) * plotH;
            g.DrawLine(new Pen(Color.Red, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash },
                       margin, yMedia, w - margin, yMedia);

            using (var f = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                g.DrawString("Índice", f, Brushes.Black, w / 2 - 20, h - 35);
                g.DrawString("Valor (0-1)", f, Brushes.Black, 5, margin - 30);
            }
        }

        private void DrawHistogram(Graphics g, Rectangle rect, List<double> datos)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (datos == null || datos.Count == 0) return;

            int margin = 50;
            int w = rect.Width;
            int h = rect.Height;

            int plotW = w - 2 * margin;
            int plotH = h - 2 * margin;

            int bins = 10;
            int[] counts = new int[bins];

            foreach (var v in datos)
            {
                int idx = (int)(v * bins);
                if (idx == bins) idx = bins - 1;
                if (idx >= 0 && idx < bins) counts[idx]++;
            }

            int maxCount = counts.Max();
            if (maxCount == 0) maxCount = 1;

            // Ejes
            g.DrawLine(Pens.Black, margin, h - margin, w - margin, h - margin);
            g.DrawLine(Pens.Black, margin, margin, margin, h - margin);

            int barWidth = plotW / bins;

            using (var f = new Font("Segoe UI", 8))
            {
                for (int i = 0; i < bins; i++)
                {
                    int barHeight = (int)((double)counts[i] / maxCount * plotH);

                    Rectangle bar = new Rectangle(
                        margin + i * barWidth + 2,
                        h - margin - barHeight,
                        barWidth - 4,
                        barHeight);

                    g.FillRectangle(Brushes.CadetBlue, bar);
                    g.DrawRectangle(Pens.Black, bar);

                    string label = $"{(double)i / bins:0.0}";
                    var size = g.MeasureString(label, f);
                    g.DrawString(label, f, Brushes.Black,
                                 margin + i * barWidth + (barWidth - size.Width) / 2,
                                 h - margin + 5);
                }
            }

            using (var f = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                g.DrawString("Intervalos [0-1]", f, Brushes.Black, w / 2 - 50, h - 35);
                g.DrawString("Frecuencia", f, Brushes.Black, 5, margin - 30);
            }
        }
    }
}
