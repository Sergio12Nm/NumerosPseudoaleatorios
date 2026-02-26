namespace Numeros_Pseudoaleatorios
{
    partial class Montecarlo
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
            dgvResultados = new DataGridView();
            btnGenerar = new Button();
            txtSemilla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblPi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(28, 172);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 374);
            dgvResultados.TabIndex = 9;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(432, 66);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla
            // 
            txtSemilla.Location = new Point(214, 81);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(150, 27);
            txtSemilla.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Ingrese semilla";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(113, 18);
            label1.Name = "label1";
            label1.Size = new Size(409, 36);
            label1.TabIndex = 5;
            label1.Text = "Método de Montecarlo";
            // 
            // lblPi
            // 
            lblPi.AutoSize = true;
            lblPi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPi.ForeColor = Color.White;
            lblPi.Location = new Point(28, 132);
            lblPi.Name = "lblPi";
            lblPi.Size = new Size(0, 20);
            lblPi.TabIndex = 10;
            // 
            // Montecarlo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(lblPi);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Montecarlo";
            Text = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla;
        private Label label2;
        private Label label1;
        private Label lblPi;
    }
}