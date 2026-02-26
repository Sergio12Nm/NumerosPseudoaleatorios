namespace Numeros_Pseudoaleatorios
{
    partial class CongruencialAditivo
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
            txtModulo = new TextBox();
            label4 = new Label();
            txtSemilla2 = new TextBox();
            label3 = new Label();
            dgvResultados = new DataGridView();
            btnGenerar = new Button();
            txtSemilla1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // txtModulo
            // 
            txtModulo.Location = new Point(227, 141);
            txtModulo.Name = "txtModulo";
            txtModulo.Size = new Size(150, 27);
            txtModulo.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 144);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 28;
            label4.Text = "Módulo";
            // 
            // txtSemilla2
            // 
            txtSemilla2.Location = new Point(227, 108);
            txtSemilla2.Name = "txtSemilla2";
            txtSemilla2.Size = new Size(150, 27);
            txtSemilla2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 26;
            label3.Text = "Ingrese semilla 2";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(29, 190);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 350);
            dgvResultados.TabIndex = 25;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(433, 93);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 24;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla1
            // 
            txtSemilla1.Location = new Point(227, 75);
            txtSemilla1.Name = "txtSemilla1";
            txtSemilla1.Size = new Size(150, 27);
            txtSemilla1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 22;
            label2.Text = "Ingrese semilla 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(530, 36);
            label1.TabIndex = 21;
            label1.Text = "Método Congruencial Aditivo";
            // 
            // CongruencialAditivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(txtModulo);
            Controls.Add(label4);
            Controls.Add(txtSemilla2);
            Controls.Add(label3);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CongruencialAditivo";
            Text = "CongruencialAditivo";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModulo;
        private Label label4;
        private TextBox txtSemilla2;
        private Label label3;
        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla1;
        private Label label2;
        private Label label1;
    }
}