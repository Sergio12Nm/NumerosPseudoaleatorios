namespace Numeros_Pseudoaleatorios
{
    partial class CuadradosMedios
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
            label1 = new Label();
            label2 = new Label();
            txtSemilla = new TextBox();
            btnGenerar = new Button();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(62, 22);
            label1.Name = "label1";
            label1.Size = new Size(520, 36);
            label1.TabIndex = 0;
            label1.Text = "Método de Cuadrados Medios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese semilla (4 dígitos)";
            // 
            // txtSemilla
            // 
            txtSemilla.Location = new Point(210, 86);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(150, 27);
            txtSemilla.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(428, 71);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(24, 139);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 412);
            dgvResultados.TabIndex = 4;
            // 
            // CuadradosMedios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CuadradosMedios";
            Text = "CuadradosMedios";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSemilla;
        private Button btnGenerar;
        private DataGridView dgvResultados;
    }
}