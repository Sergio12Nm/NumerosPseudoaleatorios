namespace Numeros_Pseudoaleatorios
{
    partial class ProductosMediosModificados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtK = new TextBox();
            label3 = new Label();
            dgvResultados = new DataGridView();
            btnGenerar = new Button();
            txtSemilla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpPruebas = new GroupBox();
            btnPruebas = new Button();
            lblPoker = new Label();
            lblCorridas = new Label();
            lblSeries = new Label();
            lblFrecuencia = new Label();
            lblVarianza = new Label();
            lblMedias = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            grpPruebas.SuspendLayout();
            SuspendLayout();
            // 
            // txtK
            // 
            txtK.Location = new Point(226, 109);
            txtK.Name = "txtK";
            txtK.Size = new Size(150, 27);
            txtK.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 112);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 17;
            label3.Text = "Ingrese semilla 2 (2 dígitos)";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(28, 156);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(583, 435);
            dgvResultados.TabIndex = 16;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(432, 76);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 15;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla
            // 
            txtSemilla.Location = new Point(226, 76);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(150, 27);
            txtSemilla.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 13;
            label2.Text = "Ingrese semilla 1 (2 dígitos)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 20);
            label1.Name = "label1";
            label1.Size = new Size(740, 36);
            label1.TabIndex = 12;
            label1.Text = "Método de Productos Medios Modificados";
            // 
            // grpPruebas
            // 
            grpPruebas.Controls.Add(btnPruebas);
            grpPruebas.Controls.Add(lblPoker);
            grpPruebas.Controls.Add(lblCorridas);
            grpPruebas.Controls.Add(lblSeries);
            grpPruebas.Controls.Add(lblFrecuencia);
            grpPruebas.Controls.Add(lblVarianza);
            grpPruebas.Controls.Add(lblMedias);
            grpPruebas.ForeColor = Color.White;
            grpPruebas.Location = new Point(617, 71);
            grpPruebas.Name = "grpPruebas";
            grpPruebas.Size = new Size(383, 520);
            grpPruebas.TabIndex = 19;
            grpPruebas.TabStop = false;
            grpPruebas.Text = "Pruebas";
            // 
            // btnPruebas
            // 
            btnPruebas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPruebas.ForeColor = Color.Black;
            btnPruebas.Location = new Point(219, 475);
            btnPruebas.Name = "btnPruebas";
            btnPruebas.Size = new Size(148, 29);
            btnPruebas.TabIndex = 6;
            btnPruebas.Text = "Ejecutar Pruebas";
            btnPruebas.UseVisualStyleBackColor = true;
            btnPruebas.Click += btnPruebas_Click;
            // 
            // lblPoker
            // 
            lblPoker.AutoSize = true;
            lblPoker.Location = new Point(12, 388);
            lblPoker.Name = "lblPoker";
            lblPoker.Size = new Size(45, 20);
            lblPoker.TabIndex = 5;
            lblPoker.Text = "Poker";
            // 
            // lblCorridas
            // 
            lblCorridas.AutoSize = true;
            lblCorridas.Location = new Point(12, 311);
            lblCorridas.Name = "lblCorridas";
            lblCorridas.Size = new Size(64, 20);
            lblCorridas.TabIndex = 4;
            lblCorridas.Text = "Corridas";
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(12, 254);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(48, 20);
            lblSeries.TabIndex = 3;
            lblSeries.Text = "Series";
            // 
            // lblFrecuencia
            // 
            lblFrecuencia.AutoSize = true;
            lblFrecuencia.Location = new Point(12, 177);
            lblFrecuencia.Name = "lblFrecuencia";
            lblFrecuencia.Size = new Size(79, 20);
            lblFrecuencia.TabIndex = 2;
            lblFrecuencia.Text = "Frecuencia";
            // 
            // lblVarianza
            // 
            lblVarianza.AutoSize = true;
            lblVarianza.Location = new Point(12, 100);
            lblVarianza.Name = "lblVarianza";
            lblVarianza.Size = new Size(65, 20);
            lblVarianza.TabIndex = 1;
            lblVarianza.Text = "Varianza";
            // 
            // lblMedias
            // 
            lblMedias.AutoSize = true;
            lblMedias.Location = new Point(12, 23);
            lblMedias.Name = "lblMedias";
            lblMedias.Size = new Size(57, 20);
            lblMedias.TabIndex = 0;
            lblMedias.Text = "Medias";
            // 
            // ProductosMediosModificados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1012, 603);
            Controls.Add(grpPruebas);
            Controls.Add(txtK);
            Controls.Add(label3);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductosMediosModificados";
            Text = "ProductosMediosModificados";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            grpPruebas.ResumeLayout(false);
            grpPruebas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtK;
        private Label label3;
        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla;
        private Label label2;
        private Label label1;
        private GroupBox grpPruebas;
        private Button btnPruebas;
        private Label lblPoker;
        private Label lblCorridas;
        private Label lblSeries;
        private Label lblFrecuencia;
        private Label lblVarianza;
        private Label lblMedias;
    }
}