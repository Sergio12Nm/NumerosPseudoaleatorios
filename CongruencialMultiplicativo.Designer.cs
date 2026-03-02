namespace Numeros_Pseudoaleatorios
{
    partial class CongruencialMultiplicativo
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
            dgvResultadosA3 = new DataGridView();
            btnGenerar = new Button();
            txtSemilla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtK = new TextBox();
            label3 = new Label();
            txtG = new TextBox();
            label4 = new Label();
            txtPeriodo1 = new TextBox();
            label5 = new Label();
            txtPeriodo2 = new TextBox();
            label6 = new Label();
            dgvResultadosA5 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA5).BeginInit();
            SuspendLayout();
            // 
            // dgvResultadosA3
            // 
            dgvResultadosA3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosA3.Location = new Point(28, 269);
            dgvResultadosA3.Name = "dgvResultadosA3";
            dgvResultadosA3.RowHeadersWidth = 51;
            dgvResultadosA3.Size = new Size(285, 280);
            dgvResultadosA3.TabIndex = 9;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MediumSeaGreen;
            btnGenerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(432, 103);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 56);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtSemilla
            // 
            txtSemilla.Location = new Point(214, 61);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(150, 27);
            txtSemilla.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 6;
            label2.Text = "Ingrese semilla (X0)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(598, 33);
            label1.TabIndex = 5;
            label1.Text = "Método Congruencial Multiplicativo";
            // 
            // txtK
            // 
            txtK.Location = new Point(214, 94);
            txtK.Name = "txtK";
            txtK.Size = new Size(150, 27);
            txtK.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 97);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 10;
            label3.Text = "k";
            // 
            // txtG
            // 
            txtG.Location = new Point(214, 127);
            txtG.Name = "txtG";
            txtG.Size = new Size(150, 27);
            txtG.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 130);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 12;
            label4.Text = "g";
            // 
            // txtPeriodo1
            // 
            txtPeriodo1.Location = new Point(214, 160);
            txtPeriodo1.Name = "txtPeriodo1";
            txtPeriodo1.ReadOnly = true;
            txtPeriodo1.Size = new Size(150, 27);
            txtPeriodo1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 163);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 14;
            label5.Text = "Periodo (3+8k)";
            // 
            // txtPeriodo2
            // 
            txtPeriodo2.Location = new Point(214, 193);
            txtPeriodo2.Name = "txtPeriodo2";
            txtPeriodo2.ReadOnly = true;
            txtPeriodo2.Size = new Size(150, 27);
            txtPeriodo2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 196);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 16;
            label6.Text = "Periodo (5+8k)";
            // 
            // dgvResultadosA5
            // 
            dgvResultadosA5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosA5.Location = new Point(334, 269);
            dgvResultadosA5.Name = "dgvResultadosA5";
            dgvResultadosA5.RowHeadersWidth = 51;
            dgvResultadosA5.Size = new Size(285, 280);
            dgvResultadosA5.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(145, 246);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 19;
            label7.Text = "3+8k";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(455, 246);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 20;
            label8.Text = "5+8k";
            // 
            // CongruencialMultiplicativo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvResultadosA5);
            Controls.Add(txtPeriodo2);
            Controls.Add(label6);
            Controls.Add(txtPeriodo1);
            Controls.Add(label5);
            Controls.Add(txtG);
            Controls.Add(label4);
            Controls.Add(txtK);
            Controls.Add(label3);
            Controls.Add(dgvResultadosA3);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CongruencialMultiplicativo";
            Text = "CongruencialMultiplicativo";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResultadosA3;
        private Button btnGenerar;
        private TextBox txtSemilla;
        private Label label2;
        private Label label1;
        private TextBox txtK;
        private Label label3;
        private TextBox txtG;
        private Label label4;
        private TextBox txtPeriodo1;
        private Label label5;
        private TextBox txtPeriodo2;
        private Label label6;
        private DataGridView dgvResultadosA5;
        private Label label7;
        private Label label8;
    }
}