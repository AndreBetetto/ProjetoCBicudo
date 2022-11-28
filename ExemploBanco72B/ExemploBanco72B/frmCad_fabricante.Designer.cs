namespace ExemploBanco72B
{
    partial class frmCad_fabricante
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
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNone = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSlavar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtIdfabricante = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(12, 58);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(128, 18);
            this.lblFabricante.TabIndex = 11;
            this.lblFabricante.Text = "ID do Fabricante:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(575, 268);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 34);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCarregarPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(146, 149);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(512, 93);
            this.txtObs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Observações:";
            // 
            // txtNone
            // 
            this.txtNone.Location = new System.Drawing.Point(146, 98);
            this.txtNone.Name = "txtNone";
            this.txtNone.Size = new System.Drawing.Size(412, 20);
            this.txtNone.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(431, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 34);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSlavar
            // 
            this.btnSlavar.Location = new System.Drawing.Point(163, 268);
            this.btnSlavar.Name = "btnSlavar";
            this.btnSlavar.Size = new System.Drawing.Size(83, 34);
            this.btnSlavar.TabIndex = 4;
            this.btnSlavar.Text = "&Salvar";
            this.btnSlavar.UseVisualStyleBackColor = true;
            this.btnSlavar.Click += new System.EventHandler(this.btnSlavar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(28, 268);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(83, 34);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtIdfabricante
            // 
            this.txtIdfabricante.Location = new System.Drawing.Point(146, 56);
            this.txtIdfabricante.Name = "txtIdfabricante";
            this.txtIdfabricante.Size = new System.Drawing.Size(127, 20);
            this.txtIdfabricante.TabIndex = 22;
            this.txtIdfabricante.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdfabricante_Validating);
            this.txtIdfabricante.Validated += new System.EventHandler(this.txtIdfabricante_Validated);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.LightGray;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(197, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(282, 27);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Projeto de Cadastro";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCad_fabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtIdfabricante);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSlavar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtNone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.btnSair);
            this.Name = "frmCad_fabricante";
            this.Text = "Cad_Fabricante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCad_fabricante_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCad_fabricante_FormClosed);
            this.Load += new System.EventHandler(this.frmCad_fabricante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNone;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSlavar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtIdfabricante;
        private System.Windows.Forms.Label lbl1;
    }
}