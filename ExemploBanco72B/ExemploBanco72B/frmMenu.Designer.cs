namespace ExemploBanco72B
{
    partial class frmMenu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCad_user = new System.Windows.Forms.Button();
            this.btnCad_Ingre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScripts = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(400, 118);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCad_user
            // 
            this.btnCad_user.Location = new System.Drawing.Point(16, 129);
            this.btnCad_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCad_user.Name = "btnCad_user";
            this.btnCad_user.Size = new System.Drawing.Size(272, 28);
            this.btnCad_user.TabIndex = 1;
            this.btnCad_user.Text = "Cadastrar novos Usuários";
            this.btnCad_user.UseVisualStyleBackColor = true;
            this.btnCad_user.Click += new System.EventHandler(this.btnCad_user_Click);
            // 
            // btnCad_Ingre
            // 
            this.btnCad_Ingre.Location = new System.Drawing.Point(16, 94);
            this.btnCad_Ingre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCad_Ingre.Name = "btnCad_Ingre";
            this.btnCad_Ingre.Size = new System.Drawing.Size(272, 28);
            this.btnCad_Ingre.TabIndex = 2;
            this.btnCad_Ingre.Text = "Cadastrar novos Ingredientes";
            this.btnCad_Ingre.UseVisualStyleBackColor = true;
            this.btnCad_Ingre.Click += new System.EventHandler(this.btnCad_Ingre_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seja bem-vindo(a) ao sistema para funcionários da Lanchonete . Usando as credenci" +
    "ais de admistrador, você pode cadastrar novos usuários, ingredientes, entre mais" +
    ".";
            // 
            // btnScripts
            // 
            this.btnScripts.Location = new System.Drawing.Point(661, 15);
            this.btnScripts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScripts.Name = "btnScripts";
            this.btnScripts.Size = new System.Drawing.Size(272, 28);
            this.btnScripts.TabIndex = 4;
            this.btnScripts.Text = "Executar Scripts no banco";
            this.btnScripts.UseVisualStyleBackColor = true;
            this.btnScripts.Click += new System.EventHandler(this.btnScripts_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(661, 51);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(272, 28);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Usuários cadastrados";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 177);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnScripts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCad_Ingre);
            this.Controls.Add(this.btnCad_user);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanchonete da Nome - Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCad_user;
        private System.Windows.Forms.Button btnCad_Ingre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScripts;
        private System.Windows.Forms.Button btnUsers;
    }
}