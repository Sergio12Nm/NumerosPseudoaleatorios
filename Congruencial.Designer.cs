namespace Numeros_Pseudoaleatorios
{
    partial class Congruencial
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
            txtC = new TextBox();
            label4 = new Label();
            txtA = new TextBox();
            label3 = new Label();
            dgvResultados = new DataGridView();
            btnGenerar = new Button();
            txtSemilla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtM = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // txtC
            // 
            txtC.Location = new Point(227, 141);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 27);
            txtC.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 144);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 28;
            label4.Text = "Incremento (c)";
            // 
            // txtA
            // 
            txtA.Location = new Point(227, 108);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 27);
            txtA.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 26;
            label3.Text = "Multiplicador (a)";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(29, 222);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(587, 318);
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
            // txtSemilla
            // 
            txtSemilla.Location = new Point(227, 75);
            txtSemilla.Name = "txtSemilla";
            txtSemilla.Size = new Size(150, 27);
            txtSemilla.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 22;
            label2.Text = "Ingrese semilla X(0)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 24);
            label1.Name = "label1";
            label1.Size = new Size(389, 36);
            label1.TabIndex = 21;
            label1.Text = "Método Congruencial";
            // 
            // txtM
            // 
            txtM.Location = new Point(227, 174);
            txtM.Name = "txtM";
            txtM.Size = new Size(150, 27);
            txtM.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 177);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 30;
            label5.Text = "Módulo (m)";
            // 
            // Congruencial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(642, 563);
            Controls.Add(txtM);
            Controls.Add(label5);
            Controls.Add(txtC);
            Controls.Add(label4);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(dgvResultados);
            Controls.Add(btnGenerar);
            Controls.Add(txtSemilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Congruencial";
            Text = "Congruencial";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtC;
        private Label label4;
        private TextBox txtA;
        private Label label3;
        private DataGridView dgvResultados;
        private Button btnGenerar;
        private TextBox txtSemilla;
        private Label label2;
        private Label label1;
        private TextBox txtM;
        private Label label5;
    }
}