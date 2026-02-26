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
            txtSemilla2 = new TextBox();
            label3 = new Label();
            dgvResultados = new DataGridView();
            btnGenerar = new Button();
            txtSemilla1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSemilla3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // txtSemilla2
            // 
            txtSemilla2.Location = new Point(226, 109);
            txtSemilla2.Name = "txtSemilla2";
            txtSemilla2.Size = new Size(150, 27);
            txtSemilla2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 112);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 17;
            label3.Text = "Ingrese semilla 2 (4 dígitos)";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(28, 191);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 350);
            dgvResultados.TabIndex = 16;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(432, 94);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 15;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla1
            // 
            txtSemilla1.Location = new Point(226, 76);
            txtSemilla1.Name = "txtSemilla1";
            txtSemilla1.Size = new Size(150, 27);
            txtSemilla1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 13;
            label2.Text = "Ingrese semilla 1 (4 dígitos)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(631, 31);
            label1.TabIndex = 12;
            label1.Text = "Método de Productos Medios Modificados";
            // 
            // txtSemilla3
            // 
            txtSemilla3.Location = new Point(226, 142);
            txtSemilla3.Name = "txtSemilla3";
            txtSemilla3.Size = new Size(150, 27);
            txtSemilla3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 145);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 19;
            label4.Text = "Ingrese semilla 3 (4 dígitos)";
            // 
            // ProductosMediosModificados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(txtSemilla3);
            Controls.Add(label4);
            Controls.Add(txtSemilla2);
            Controls.Add(label3);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductosMediosModificados";
            Text = "ProductosMediosModificados";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSemilla2;
        private Label label3;
        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla1;
        private Label label2;
        private Label label1;
        private TextBox txtSemilla3;
        private Label label4;
    }
}