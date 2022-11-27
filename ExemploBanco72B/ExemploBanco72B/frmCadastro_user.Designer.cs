namespace ExemploBanco72B
{
    partial class frmCadastro_user
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DateTimePicker dtpNascimento;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro_user));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.lblCSenha = new System.Windows.Forms.Label();
            this.radAdmsim = new System.Windows.Forms.RadioButton();
            this.lblAdm = new System.Windows.Forms.Label();
            this.radAdmnão = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            dtpNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNascimento
            // 
            dtpNascimento.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtpNascimento.CustomFormat = "";
            dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNascimento.Location = new System.Drawing.Point(224, 192);
            dtpNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new System.Drawing.Size(325, 22);
            dtpNascimento.TabIndex = 38;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(279, 11);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(375, 33);
            this.lbl1.TabIndex = 35;
            this.lbl1.Text = "Cadastro de Usuário";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(224, 146);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(168, 22);
            this.txtCPF.TabIndex = 34;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(216, 508);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 42);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(400, 508);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 42);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNone
            // 
            this.txtNone.Location = new System.Drawing.Point(224, 82);
            this.txtNone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNone.MaxLength = 100;
            this.txtNone.Name = "txtNone";
            this.txtNone.Size = new System.Drawing.Size(548, 22);
            this.txtNone.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(64, 150);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(53, 23);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CPF:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(765, 508);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 42);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(224, 114);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(548, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(64, 117);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 23);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(0, 192);
            this.lblDataNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(207, 23);
            this.lblDataNasc.TabIndex = 39;
            this.lblDataNasc.Text = "Data d/ nascimento:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(224, 224);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(168, 22);
            this.txtCEP.TabIndex = 41;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(64, 226);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(55, 23);
            this.lblCEP.TabIndex = 40;
            this.lblCEP.Text = "CEP:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(224, 256);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 22);
            this.txtTelefone.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Telefone:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(224, 289);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 22);
            this.txtSenha.TabIndex = 45;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(45, 288);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(78, 23);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "Senha:";
            // 
            // txtCSenha
            // 
            this.txtCSenha.Location = new System.Drawing.Point(224, 321);
            this.txtCSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCSenha.MaxLength = 25;
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.Size = new System.Drawing.Size(168, 22);
            this.txtCSenha.TabIndex = 47;
            // 
            // lblCSenha
            // 
            this.lblCSenha.AutoSize = true;
            this.lblCSenha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSenha.Location = new System.Drawing.Point(16, 320);
            this.lblCSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCSenha.Name = "lblCSenha";
            this.lblCSenha.Size = new System.Drawing.Size(177, 23);
            this.lblCSenha.TabIndex = 46;
            this.lblCSenha.Text = "Confirmar senha:";
            // 
            // radAdmsim
            // 
            this.radAdmsim.AutoSize = true;
            this.radAdmsim.Enabled = false;
            this.radAdmsim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmsim.Location = new System.Drawing.Point(216, 380);
            this.radAdmsim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radAdmsim.Name = "radAdmsim";
            this.radAdmsim.Size = new System.Drawing.Size(53, 21);
            this.radAdmsim.TabIndex = 48;
            this.radAdmsim.Text = "sim";
            this.radAdmsim.UseVisualStyleBackColor = true;
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(40, 378);
            this.lblAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(80, 23);
            this.lblAdm.TabIndex = 49;
            this.lblAdm.Text = "É adm?";
            // 
            // radAdmnão
            // 
            this.radAdmnão.AutoSize = true;
            this.radAdmnão.Checked = true;
            this.radAdmnão.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmnão.Location = new System.Drawing.Point(277, 380);
            this.radAdmnão.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radAdmnão.Name = "radAdmnão";
            this.radAdmnão.Size = new System.Drawing.Size(55, 21);
            this.radAdmnão.TabIndex = 50;
            this.radAdmnão.TabStop = true;
            this.radAdmnão.Text = "não";
            this.radAdmnão.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radAdmnão);
            this.Controls.Add(this.lblAdm);
            this.Controls.Add(this.radAdmsim);
            this.Controls.Add(this.txtCSenha);
            this.Controls.Add(this.lblCSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(dtpNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnSair);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastro_user";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadastro_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.Label lblCSenha;
        private System.Windows.Forms.RadioButton radAdmsim;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.RadioButton radAdmnão;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}