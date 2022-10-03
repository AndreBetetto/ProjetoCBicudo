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
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnPesquisarAparelhos = new System.Windows.Forms.Button();
            this.cmbFabricantes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 182);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(643, 223);
            this.dgvPesquisa.TabIndex = 0;
            // 
            // btnCarregarPesquisa
            // 
            this.btnCarregarPesquisa.Location = new System.Drawing.Point(486, 411);
            this.btnCarregarPesquisa.Name = "btnCarregarPesquisa";
            this.btnCarregarPesquisa.Size = new System.Drawing.Size(169, 34);
            this.btnCarregarPesquisa.TabIndex = 1;
            this.btnCarregarPesquisa.Text = "Carregar &Pesquisa";
            this.btnCarregarPesquisa.UseVisualStyleBackColor = true;
            this.btnCarregarPesquisa.Click += new System.EventHandler(this.btnCarregarPesquisa_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(12, 69);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQL.Size = new System.Drawing.Size(643, 93);
            this.txtSQL.TabIndex = 2;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(12, 29);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(95, 18);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Fabricantes:";
            // 
            // btnPesquisarAparelhos
            // 
            this.btnPesquisarAparelhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAparelhos.Location = new System.Drawing.Point(288, 24);
            this.btnPesquisarAparelhos.Name = "btnPesquisarAparelhos";
            this.btnPesquisarAparelhos.Size = new System.Drawing.Size(198, 26);
            this.btnPesquisarAparelhos.TabIndex = 6;
            this.btnPesquisarAparelhos.Text = "Pesquisar Aparelhos";
            this.btnPesquisarAparelhos.UseVisualStyleBackColor = true;
            this.btnPesquisarAparelhos.Click += new System.EventHandler(this.btnPesquisarAparelhos_Click);
            // 
            // cmbFabricantes
            // 
            this.cmbFabricantes.FormattingEnabled = true;
            this.cmbFabricantes.Location = new System.Drawing.Point(113, 30);
            this.cmbFabricantes.Name = "cmbFabricantes";
            this.cmbFabricantes.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricantes.TabIndex = 7;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.cmbFabricantes);
            this.Controls.Add(this.btnPesquisarAparelhos);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnCarregarPesquisa);
            this.Controls.Add(this.dgvPesquisa);
            this.Name = "frmPesquisa";
            this.Text = "Exemplo Banco 72B";
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
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button btnPesquisarAparelhos;
        private System.Windows.Forms.ComboBox cmbFabricantes;
    }
}

