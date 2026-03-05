namespace Numeros_Pseudoaleatorios
{
    partial class Numeros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCuadradosMedios = new Button();
            btnProductosMedios = new Button();
            btnProductosMediosModificados = new Button();
            label1 = new Label();
            btnNeumann = new Button();
            btnCongruencial = new Button();
            btnCongruencialAditivo = new Button();
            btnCongruencialMultiplicativo = new Button();
            btnMontecarlo = new Button();
            SuspendLayout();
            // 
            // btnCuadradosMedios
            // 
            btnCuadradosMedios.BackColor = Color.MediumSeaGreen;
            btnCuadradosMedios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCuadradosMedios.ForeColor = Color.White;
            btnCuadradosMedios.Location = new Point(39, 111);
            btnCuadradosMedios.Name = "btnCuadradosMedios";
            btnCuadradosMedios.Size = new Size(260, 70);
            btnCuadradosMedios.TabIndex = 0;
            btnCuadradosMedios.Text = "Cuadrados Medios";
            btnCuadradosMedios.UseVisualStyleBackColor = false;
            btnCuadradosMedios.Click += btnCuadradosMedios_Click;
            // 
            // btnProductosMedios
            // 
            btnProductosMedios.BackColor = Color.MediumSeaGreen;
            btnProductosMedios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProductosMedios.ForeColor = Color.White;
            btnProductosMedios.Location = new Point(335, 111);
            btnProductosMedios.Name = "btnProductosMedios";
            btnProductosMedios.Size = new Size(260, 70);
            btnProductosMedios.TabIndex = 1;
            btnProductosMedios.Text = "Productos Medios";
            btnProductosMedios.UseVisualStyleBackColor = false;
            btnProductosMedios.Click += btnProductosMedios_Click;
            // 
            // btnProductosMediosModificados
            // 
            btnProductosMediosModificados.BackColor = Color.MediumSeaGreen;
            btnProductosMediosModificados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProductosMediosModificados.ForeColor = Color.White;
            btnProductosMediosModificados.Location = new Point(39, 199);
            btnProductosMediosModificados.Name = "btnProductosMediosModificados";
            btnProductosMediosModificados.Size = new Size(260, 70);
            btnProductosMediosModificados.TabIndex = 2;
            btnProductosMediosModificados.Text = "Productos Medios Modificados";
            btnProductosMediosModificados.UseVisualStyleBackColor = false;
            btnProductosMediosModificados.Click += btnProductosMediosModificados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 82);
            label1.TabIndex = 3;
            label1.Text = "Números\r\nPseudoaleatorios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNeumann
            // 
            btnNeumann.BackColor = Color.MediumSeaGreen;
            btnNeumann.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnNeumann.ForeColor = Color.White;
            btnNeumann.Location = new Point(335, 199);
            btnNeumann.Name = "btnNeumann";
            btnNeumann.Size = new Size(260, 70);
            btnNeumann.TabIndex = 4;
            btnNeumann.Text = "Neumann";
            btnNeumann.UseVisualStyleBackColor = false;
            btnNeumann.Click += btnNeumann_Click;
            // 
            // btnCongruencial
            // 
            btnCongruencial.BackColor = Color.MediumSeaGreen;
            btnCongruencial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCongruencial.ForeColor = Color.White;
            btnCongruencial.Location = new Point(39, 289);
            btnCongruencial.Name = "btnCongruencial";
            btnCongruencial.Size = new Size(260, 70);
            btnCongruencial.TabIndex = 5;
            btnCongruencial.Text = "Congruencial";
            btnCongruencial.UseVisualStyleBackColor = false;
            btnCongruencial.Click += btnCongruencial_Click;
            // 
            // btnCongruencialAditivo
            // 
            btnCongruencialAditivo.BackColor = Color.MediumSeaGreen;
            btnCongruencialAditivo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCongruencialAditivo.ForeColor = Color.White;
            btnCongruencialAditivo.Location = new Point(335, 289);
            btnCongruencialAditivo.Name = "btnCongruencialAditivo";
            btnCongruencialAditivo.Size = new Size(260, 70);
            btnCongruencialAditivo.TabIndex = 6;
            btnCongruencialAditivo.Text = "Congruencial Aditivo";
            btnCongruencialAditivo.UseVisualStyleBackColor = false;
            btnCongruencialAditivo.Click += btnCongruencialAditivo_Click;
            // 
            // btnCongruencialMultiplicativo
            // 
            btnCongruencialMultiplicativo.BackColor = Color.MediumSeaGreen;
            btnCongruencialMultiplicativo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCongruencialMultiplicativo.ForeColor = Color.White;
            btnCongruencialMultiplicativo.Location = new Point(39, 380);
            btnCongruencialMultiplicativo.Name = "btnCongruencialMultiplicativo";
            btnCongruencialMultiplicativo.Size = new Size(260, 70);
            btnCongruencialMultiplicativo.TabIndex = 7;
            btnCongruencialMultiplicativo.Text = "Congruencial Multiplicativo";
            btnCongruencialMultiplicativo.UseVisualStyleBackColor = false;
            btnCongruencialMultiplicativo.Click += btnCongruencialMultiplicativo_Click;
            // 
            // btnMontecarlo
            // 
            btnMontecarlo.BackColor = Color.MediumSeaGreen;
            btnMontecarlo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnMontecarlo.ForeColor = Color.White;
            btnMontecarlo.Location = new Point(335, 380);
            btnMontecarlo.Name = "btnMontecarlo";
            btnMontecarlo.Size = new Size(260, 70);
            btnMontecarlo.TabIndex = 8;
            btnMontecarlo.Text = "Montecarlo";
            btnMontecarlo.UseVisualStyleBackColor = false;
            btnMontecarlo.Click += btnMontecarlo_Click;
            // 
            // Numeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(632, 563);
            Controls.Add(btnMontecarlo);
            Controls.Add(btnCongruencialMultiplicativo);
            Controls.Add(btnCongruencialAditivo);
            Controls.Add(btnCongruencial);
            Controls.Add(btnNeumann);
            Controls.Add(label1);
            Controls.Add(btnProductosMediosModificados);
            Controls.Add(btnProductosMedios);
            Controls.Add(btnCuadradosMedios);
            Name = "Numeros";
            Text = "Números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCuadradosMedios;
        private Button btnProductosMedios;
        private Button btnProductosMediosModificados;
        private Label label1;
        private Button btnNeumann;
        private Button btnCongruencial;
        private Button btnCongruencialAditivo;
        private Button btnCongruencialMultiplicativo;
        private Button btnMontecarlo;
    }
}
