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
            grpPruebas = new GroupBox();
            btnPruebas3 = new Button();
            btnPruebas5 = new Button();
            lblPoker = new Label();
            lblCorridas = new Label();
            lblSeries = new Label();
            lblFrecuencia = new Label();
            lblVarianza = new Label();
            lblMedias = new Label();
            btnGraficosA3 = new Button();
            btnGraficosA5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA5).BeginInit();
            grpPruebas.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResultadosA3
            // 
            dgvResultadosA3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosA3.Location = new Point(28, 269);
            dgvResultadosA3.Name = "dgvResultadosA3";
            dgvResultadosA3.RowHeadersWidth = 51;
            dgvResultadosA3.Size = new Size(285, 322);
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
            label1.Font = new Font("Pusab", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(656, 36);
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
            dgvResultadosA5.Location = new Point(324, 269);
            dgvResultadosA5.Name = "dgvResultadosA5";
            dgvResultadosA5.RowHeadersWidth = 51;
            dgvResultadosA5.Size = new Size(285, 322);
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
            label8.Location = new Point(445, 246);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 20;
            label8.Text = "5+8k";
            // 
            // grpPruebas
            // 
            grpPruebas.Controls.Add(btnPruebas3);
            grpPruebas.Controls.Add(btnPruebas5);
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
            grpPruebas.TabIndex = 37;
            grpPruebas.TabStop = false;
            grpPruebas.Text = "Pruebas";
            // 
            // btnPruebas3
            // 
            btnPruebas3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPruebas3.ForeColor = Color.Black;
            btnPruebas3.Location = new Point(194, 440);
            btnPruebas3.Name = "btnPruebas3";
            btnPruebas3.Size = new Size(170, 29);
            btnPruebas3.TabIndex = 7;
            btnPruebas3.Text = "Ejecutar Pruebas 3+8k";
            btnPruebas3.UseVisualStyleBackColor = true;
            btnPruebas3.Click += btnPruebas3_Click;
            // 
            // btnPruebas5
            // 
            btnPruebas5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPruebas5.ForeColor = Color.Black;
            btnPruebas5.Location = new Point(194, 475);
            btnPruebas5.Name = "btnPruebas5";
            btnPruebas5.Size = new Size(170, 29);
            btnPruebas5.TabIndex = 6;
            btnPruebas5.Text = "Ejecutar Pruebas 5+8k";
            btnPruebas5.UseVisualStyleBackColor = true;
            btnPruebas5.Click += btnPruebas5_Click;
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
            // btnGraficosA3
            // 
            btnGraficosA3.Location = new Point(12, 12);
            btnGraficosA3.Name = "btnGraficosA3";
            btnGraficosA3.Size = new Size(75, 25);
            btnGraficosA3.TabIndex = 10;
            btnGraficosA3.Text = "Gráf A3";
            btnGraficosA3.UseVisualStyleBackColor = true;
            btnGraficosA3.Click += btnGraficosA3_Click;
            // 
            // btnGraficosA5
            // 
            btnGraficosA5.Location = new Point(100, 12);
            btnGraficosA5.Name = "btnGraficosA5";
            btnGraficosA5.Size = new Size(75, 25);
            btnGraficosA5.TabIndex = 11;
            btnGraficosA5.Text = "Gráf A5";
            btnGraficosA5.UseVisualStyleBackColor = true;
            btnGraficosA5.Click += btnGraficosA5_Click;
            // 
            // CongruencialMultiplicativo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1012, 603);
            Controls.Add(grpPruebas);
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
            Controls.Add(btnGraficosA5);
            Controls.Add(btnGraficosA3);
            Name = "CongruencialMultiplicativo";
            Text = "CongruencialMultiplicativo";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosA5).EndInit();
            grpPruebas.ResumeLayout(false);
            grpPruebas.PerformLayout();
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
        private GroupBox grpPruebas;
        private Button btnPruebas5;
        private Label lblPoker;
        private Label lblCorridas;
        private Label lblSeries;
        private Label lblFrecuencia;
        private Label lblVarianza;
        private Label lblMedias;
        private Button btnPruebas3;
        private Button btnGraficosA3;
        private Button btnGraficosA5;
    }
}