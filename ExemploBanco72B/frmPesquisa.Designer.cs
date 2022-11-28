namespace ExemploBanco72B
{
    partial class frmPesquisa
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
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnCarregarPesquisa = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.btnConsulta5 = new System.Windows.Forms.Button();
            this.btnConsulta6 = new System.Windows.Forms.Button();
            this.btnConsulta7 = new System.Windows.Forms.Button();
            this.btnConsulta8 = new System.Windows.Forms.Button();
            this.btnConsulta9 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(16, 224);
            this.dgvPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersWidth = 51;
            this.dgvPesquisa.Size = new System.Drawing.Size(857, 297);
            this.dgvPesquisa.TabIndex = 0;
            // 
            // btnCarregarPesquisa
            // 
            this.btnCarregarPesquisa.Location = new System.Drawing.Point(16, 528);
            this.btnCarregarPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregarPesquisa.Name = "btnCarregarPesquisa";
            this.btnCarregarPesquisa.Size = new System.Drawing.Size(225, 42);
            this.btnCarregarPesquisa.TabIndex = 1;
            this.btnCarregarPesquisa.Text = "Carregar &Pesquisa";
            this.btnCarregarPesquisa.UseVisualStyleBackColor = true;
            this.btnCarregarPesquisa.Click += new System.EventHandler(this.btnCarregarPesquisa_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(16, 85);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQL.Size = new System.Drawing.Size(856, 114);
            this.txtSQL.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 36);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 23);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Executar Script";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(897, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cosultas principais";
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(892, 85);
            this.btnConsulta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta1.TabIndex = 6;
            this.btnConsulta1.Text = "Cosultar todos os ingredientes";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(892, 134);
            this.btnConsulta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta2.TabIndex = 7;
            this.btnConsulta2.Text = "Consultar todos os pães";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(892, 183);
            this.btnConsulta3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta3.TabIndex = 8;
            this.btnConsulta3.Text = "Consultar todas as proteínas";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Location = new System.Drawing.Point(892, 233);
            this.btnConsulta4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta4.TabIndex = 9;
            this.btnConsulta4.Text = "Consultar todos os laticínios";
            this.btnConsulta4.UseVisualStyleBackColor = true;
            this.btnConsulta4.Click += new System.EventHandler(this.btnConsulta4_Click);
            // 
            // btnConsulta5
            // 
            this.btnConsulta5.Location = new System.Drawing.Point(892, 282);
            this.btnConsulta5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta5.Name = "btnConsulta5";
            this.btnConsulta5.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta5.TabIndex = 10;
            this.btnConsulta5.Text = "Consultar todos os molhos";
            this.btnConsulta5.UseVisualStyleBackColor = true;
            this.btnConsulta5.Click += new System.EventHandler(this.btnConsulta5_Click);
            // 
            // btnConsulta6
            // 
            this.btnConsulta6.Location = new System.Drawing.Point(892, 331);
            this.btnConsulta6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta6.Name = "btnConsulta6";
            this.btnConsulta6.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta6.TabIndex = 11;
            this.btnConsulta6.Text = "Consultar todas as saladas";
            this.btnConsulta6.UseVisualStyleBackColor = true;
            this.btnConsulta6.Click += new System.EventHandler(this.btnConsulta6_Click);
            // 
            // btnConsulta7
            // 
            this.btnConsulta7.Location = new System.Drawing.Point(892, 380);
            this.btnConsulta7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta7.Name = "btnConsulta7";
            this.btnConsulta7.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta7.TabIndex = 12;
            this.btnConsulta7.Text = "Consultar todos os acompanhamentos";
            this.btnConsulta7.UseVisualStyleBackColor = true;
            this.btnConsulta7.Click += new System.EventHandler(this.btnConsulta7_Click);
            // 
            // btnConsulta8
            // 
            this.btnConsulta8.Location = new System.Drawing.Point(892, 430);
            this.btnConsulta8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta8.Name = "btnConsulta8";
            this.btnConsulta8.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta8.TabIndex = 13;
            this.btnConsulta8.Text = "Consultar todas as sobremesas";
            this.btnConsulta8.UseVisualStyleBackColor = true;
            this.btnConsulta8.Click += new System.EventHandler(this.btnConsulta8_Click);
            // 
            // btnConsulta9
            // 
            this.btnConsulta9.Location = new System.Drawing.Point(892, 479);
            this.btnConsulta9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta9.Name = "btnConsulta9";
            this.btnConsulta9.Size = new System.Drawing.Size(193, 42);
            this.btnConsulta9.TabIndex = 14;
            this.btnConsulta9.Text = "Consultar todosos lanches";
            this.btnConsulta9.UseVisualStyleBackColor = true;
            this.btnConsulta9.Click += new System.EventHandler(this.btnConsulta9_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(648, 528);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(225, 42);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar pesquisa";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 581);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsulta9);
            this.Controls.Add(this.btnConsulta8);
            this.Controls.Add(this.btnConsulta7);
            this.Controls.Add(this.btnConsulta6);
            this.Controls.Add(this.btnConsulta5);
            this.Controls.Add(this.btnConsulta4);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnCarregarPesquisa);
            this.Controls.Add(this.dgvPesquisa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesquisa";
            this.Text = "Executar Scripts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPesquisa_FormClosing);
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btnCarregarPesquisa;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Button btnConsulta4;
        private System.Windows.Forms.Button btnConsulta5;
        private System.Windows.Forms.Button btnConsulta6;
        private System.Windows.Forms.Button btnConsulta7;
        private System.Windows.Forms.Button btnConsulta8;
        private System.Windows.Forms.Button btnConsulta9;
        private System.Windows.Forms.Button btnLimpar;
    }
}

