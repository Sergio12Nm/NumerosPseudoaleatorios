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
            btnSimular = new Button();
            txtMonedas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblPi = new Label();
            txtDados = new TextBox();
            label3 = new Label();
            lblResumen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 161);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(404, 390);
            dgvResultados.TabIndex = 9;
            // 
            // btnSimular
            // 
            btnSimular.BackColor = Color.MediumSeaGreen;
            btnSimular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimular.ForeColor = Color.White;
            btnSimular.Location = new Point(432, 66);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(137, 56);
            btnSimular.TabIndex = 8;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = false;
            btnSimular.Click += btnGenerar_Click;
            // 
            // txtMonedas
            // 
            txtMonedas.Location = new Point(214, 70);
            txtMonedas.Name = "txtMonedas";
            txtMonedas.Size = new Size(150, 27);
            txtMonedas.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 73);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Monedas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(143, 18);
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
            // txtDados
            // 
            txtDados.Location = new Point(214, 103);
            txtDados.Name = "txtDados";
            txtDados.Size = new Size(150, 27);
            txtDados.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 106);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 11;
            label3.Text = "Dados";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.ForeColor = Color.White;
            lblResumen.Location = new Point(432, 161);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(69, 20);
            lblResumen.TabIndex = 13;
            lblResumen.Text = "Resumen";
            // 
            // Montecarlo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(702, 563);
            Controls.Add(lblResumen);
            Controls.Add(txtDados);
            Controls.Add(label3);
            Controls.Add(lblPi);
            Controls.Add(dgvResultados);
            Controls.Add(btnSimular);
            Controls.Add(txtMonedas);
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
        private Button btnSimular;
        private TextBox txtMonedas;
        private Label label2;
        private Label label1;
        private Label lblPi;
        private TextBox txtDados;
        private Label label3;
        private Label lblResumen;
    }
}