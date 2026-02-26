namespace Numeros_Pseudoaleatorios
{
    partial class ProductosMedios
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
            txtSemilla1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSemilla2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(28, 156);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 385);
            dgvResultados.TabIndex = 9;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(432, 73);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla1
            // 
            txtSemilla1.Location = new Point(226, 76);
            txtSemilla1.Name = "txtSemilla1";
            txtSemilla1.Size = new Size(150, 27);
            txtSemilla1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 6;
            label2.Text = "Ingrese semilla 1 (4 dígitos)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 19);
            label1.Name = "label1";
            label1.Size = new Size(517, 36);
            label1.TabIndex = 5;
            label1.Text = "Método de Productos Medios";
            // 
            // txtSemilla2
            // 
            txtSemilla2.Location = new Point(226, 109);
            txtSemilla2.Name = "txtSemilla2";
            txtSemilla2.Size = new Size(150, 27);
            txtSemilla2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 112);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 10;
            label3.Text = "Ingrese semilla 2 (4 dígitos)";
            // 
            // ProductosMedios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(txtSemilla2);
            Controls.Add(label3);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductosMedios";
            Text = "ProductosMedios";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla1;
        private Label label2;
        private Label label1;
        private TextBox txtSemilla2;
        private Label label3;
    }
}