﻿namespace ExemploBanco72B
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
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCad_user
            // 
            this.btnCad_user.Location = new System.Drawing.Point(12, 105);
            this.btnCad_user.Name = "btnCad_user";
            this.btnCad_user.Size = new System.Drawing.Size(204, 23);
            this.btnCad_user.TabIndex = 1;
            this.btnCad_user.Text = "Cadastrar novos Usuários";
            this.btnCad_user.UseVisualStyleBackColor = true;
            this.btnCad_user.Click += new System.EventHandler(this.btnCad_user_Click);
            // 
            // btnCad_Ingre
            // 
            this.btnCad_Ingre.Location = new System.Drawing.Point(12, 76);
            this.btnCad_Ingre.Name = "btnCad_Ingre";
            this.btnCad_Ingre.Size = new System.Drawing.Size(204, 23);
            this.btnCad_Ingre.TabIndex = 2;
            this.btnCad_Ingre.Text = "Cadastrar novos Ingredientes";
            this.btnCad_Ingre.UseVisualStyleBackColor = true;
            this.btnCad_Ingre.Click += new System.EventHandler(this.btnCad_Ingre_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 144);
            this.Controls.Add(this.btnCad_Ingre);
            this.Controls.Add(this.btnCad_user);
            this.Controls.Add(this.btnLogout);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCad_user;
        private System.Windows.Forms.Button btnCad_Ingre;
    }
}