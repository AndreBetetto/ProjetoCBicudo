namespace ExemploBanco72B
{
    partial class Lanches
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMontar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomelanche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMol = new System.Windows.Forms.ComboBox();
            this.comboSal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPao = new System.Windows.Forms.ComboBox();
            this.radLanche2 = new System.Windows.Forms.RadioButton();
            this.radLanche1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLanche = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboAcom = new System.Windows.Forms.ComboBox();
            this.radAcom2 = new System.Windows.Forms.RadioButton();
            this.radAcom1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSobre = new System.Windows.Forms.ComboBox();
            this.radSobre2 = new System.Windows.Forms.RadioButton();
            this.radSobre1 = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.dgvPesquisa2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fazer pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radLanche2);
            this.groupBox1.Controls.Add(this.radLanche1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboLanche);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lanche";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMontar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNomelanche);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboMol);
            this.groupBox2.Controls.Add(this.comboSal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboLat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboPro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboPao);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monte seu lanche personalizado";
            // 
            // btnMontar
            // 
            this.btnMontar.Location = new System.Drawing.Point(6, 240);
            this.btnMontar.Name = "btnMontar";
            this.btnMontar.Size = new System.Drawing.Size(220, 23);
            this.btnMontar.TabIndex = 3;
            this.btnMontar.Text = "Adicionar à lista de lanches";
            this.btnMontar.UseVisualStyleBackColor = true;
            this.btnMontar.Click += new System.EventHandler(this.btnMontar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "De um nome ao seu lanche";
            // 
            // txtNomelanche
            // 
            this.txtNomelanche.Location = new System.Drawing.Point(9, 42);
            this.txtNomelanche.Name = "txtNomelanche";
            this.txtNomelanche.Size = new System.Drawing.Size(225, 20);
            this.txtNomelanche.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Escolha o molho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Escolha a salada";
            // 
            // comboMol
            // 
            this.comboMol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMol.FormattingEnabled = true;
            this.comboMol.Location = new System.Drawing.Point(105, 210);
            this.comboMol.Name = "comboMol";
            this.comboMol.Size = new System.Drawing.Size(121, 21);
            this.comboMol.TabIndex = 6;
            // 
            // comboSal
            // 
            this.comboSal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSal.FormattingEnabled = true;
            this.comboSal.Location = new System.Drawing.Point(105, 183);
            this.comboSal.Name = "comboSal";
            this.comboSal.Size = new System.Drawing.Size(121, 21);
            this.comboSal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Escolha o laticínio";
            // 
            // comboLat
            // 
            this.comboLat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLat.FormattingEnabled = true;
            this.comboLat.Location = new System.Drawing.Point(105, 156);
            this.comboLat.Name = "comboLat";
            this.comboLat.Size = new System.Drawing.Size(121, 21);
            this.comboLat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Escolha a proteína";
            // 
            // comboPro
            // 
            this.comboPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPro.FormattingEnabled = true;
            this.comboPro.Location = new System.Drawing.Point(105, 127);
            this.comboPro.Name = "comboPro";
            this.comboPro.Size = new System.Drawing.Size(121, 21);
            this.comboPro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escolha o pão";
            // 
            // comboPao
            // 
            this.comboPao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPao.FormattingEnabled = true;
            this.comboPao.Location = new System.Drawing.Point(105, 100);
            this.comboPao.Name = "comboPao";
            this.comboPao.Size = new System.Drawing.Size(121, 21);
            this.comboPao.TabIndex = 1;
            // 
            // radLanche2
            // 
            this.radLanche2.AutoSize = true;
            this.radLanche2.Location = new System.Drawing.Point(11, 43);
            this.radLanche2.Name = "radLanche2";
            this.radLanche2.Size = new System.Drawing.Size(118, 17);
            this.radLanche2.TabIndex = 4;
            this.radLanche2.Text = "Escolher um lanche";
            this.radLanche2.UseVisualStyleBackColor = true;
            this.radLanche2.CheckedChanged += new System.EventHandler(this.radLanche2_CheckedChanged);
            // 
            // radLanche1
            // 
            this.radLanche1.AutoSize = true;
            this.radLanche1.Checked = true;
            this.radLanche1.Location = new System.Drawing.Point(11, 20);
            this.radLanche1.Name = "radLanche1";
            this.radLanche1.Size = new System.Drawing.Size(81, 17);
            this.radLanche1.TabIndex = 3;
            this.radLanche1.TabStop = true;
            this.radLanche1.Text = "Sem lanche";
            this.radLanche1.UseVisualStyleBackColor = true;
            this.radLanche1.CheckedChanged += new System.EventHandler(this.radLanche1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione um lanche";
            // 
            // comboLanche
            // 
            this.comboLanche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanche.Enabled = false;
            this.comboLanche.FormattingEnabled = true;
            this.comboLanche.Location = new System.Drawing.Point(11, 120);
            this.comboLanche.Name = "comboLanche";
            this.comboLanche.Size = new System.Drawing.Size(121, 21);
            this.comboLanche.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboAcom);
            this.groupBox3.Controls.Add(this.radAcom2);
            this.groupBox3.Controls.Add(this.radAcom1);
            this.groupBox3.Location = new System.Drawing.Point(298, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 226);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acompanhamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Selecione um acompanhamento";
            // 
            // comboAcom
            // 
            this.comboAcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAcom.Enabled = false;
            this.comboAcom.FormattingEnabled = true;
            this.comboAcom.Location = new System.Drawing.Point(9, 120);
            this.comboAcom.Name = "comboAcom";
            this.comboAcom.Size = new System.Drawing.Size(121, 21);
            this.comboAcom.TabIndex = 7;
            // 
            // radAcom2
            // 
            this.radAcom2.AutoSize = true;
            this.radAcom2.Location = new System.Drawing.Point(6, 43);
            this.radAcom2.Name = "radAcom2";
            this.radAcom2.Size = new System.Drawing.Size(171, 17);
            this.radAcom2.TabIndex = 6;
            this.radAcom2.Text = "Escolher um acompanhamento";
            this.radAcom2.UseVisualStyleBackColor = true;
            this.radAcom2.CheckedChanged += new System.EventHandler(this.radAcom2_CheckedChanged);
            // 
            // radAcom1
            // 
            this.radAcom1.AutoSize = true;
            this.radAcom1.Checked = true;
            this.radAcom1.Location = new System.Drawing.Point(6, 20);
            this.radAcom1.Name = "radAcom1";
            this.radAcom1.Size = new System.Drawing.Size(134, 17);
            this.radAcom1.TabIndex = 5;
            this.radAcom1.TabStop = true;
            this.radAcom1.Text = "Sem acompanhamento";
            this.radAcom1.UseVisualStyleBackColor = true;
            this.radAcom1.CheckedChanged += new System.EventHandler(this.radAcom1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.comboSobre);
            this.groupBox4.Controls.Add(this.radSobre2);
            this.groupBox4.Controls.Add(this.radSobre1);
            this.groupBox4.Location = new System.Drawing.Point(569, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 226);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sobremesa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Selecione uma das nossas delicaosas sobremesas";
            // 
            // comboSobre
            // 
            this.comboSobre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSobre.Enabled = false;
            this.comboSobre.FormattingEnabled = true;
            this.comboSobre.Location = new System.Drawing.Point(9, 120);
            this.comboSobre.Name = "comboSobre";
            this.comboSobre.Size = new System.Drawing.Size(121, 21);
            this.comboSobre.TabIndex = 9;
            // 
            // radSobre2
            // 
            this.radSobre2.AutoSize = true;
            this.radSobre2.Location = new System.Drawing.Point(6, 43);
            this.radSobre2.Name = "radSobre2";
            this.radSobre2.Size = new System.Drawing.Size(143, 17);
            this.radSobre2.TabIndex = 8;
            this.radSobre2.Text = "Escolher uma sobremesa";
            this.radSobre2.UseVisualStyleBackColor = true;
            this.radSobre2.CheckedChanged += new System.EventHandler(this.radSobre2_CheckedChanged);
            // 
            // radSobre1
            // 
            this.radSobre1.AutoSize = true;
            this.radSobre1.Checked = true;
            this.radSobre1.Location = new System.Drawing.Point(6, 20);
            this.radSobre1.Name = "radSobre1";
            this.radSobre1.Size = new System.Drawing.Size(100, 17);
            this.radSobre1.TabIndex = 7;
            this.radSobre1.TabStop = true;
            this.radSobre1.Text = "Sem sobremesa";
            this.radSobre1.UseVisualStyleBackColor = true;
            this.radSobre1.CheckedChanged += new System.EventHandler(this.radSobre1_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(530, 397);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir pedido";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(352, 397);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(723, 397);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(111, 23);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(298, 289);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(19, 136);
            this.dgvPesquisa.TabIndex = 8;
            this.dgvPesquisa.Visible = false;
            // 
            // dgvPesquisa2
            // 
            this.dgvPesquisa2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa2.Location = new System.Drawing.Point(299, 431);
            this.dgvPesquisa2.Name = "dgvPesquisa2";
            this.dgvPesquisa2.Size = new System.Drawing.Size(18, 76);
            this.dgvPesquisa2.TabIndex = 9;
            this.dgvPesquisa2.Visible = false;
            // 
            // Lanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 519);
            this.Controls.Add(this.dgvPesquisa2);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Lanches";
            this.Text = "Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lanches_FormClosing);
            this.Load += new System.EventHandler(this.Lanches_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radLanche2;
        private System.Windows.Forms.RadioButton radLanche1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLanche;
        private System.Windows.Forms.Button btnMontar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomelanche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboMol;
        private System.Windows.Forms.ComboBox comboSal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboAcom;
        private System.Windows.Forms.RadioButton radAcom2;
        private System.Windows.Forms.RadioButton radAcom1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboSobre;
        private System.Windows.Forms.RadioButton radSobre2;
        private System.Windows.Forms.RadioButton radSobre1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisa2;
    }
}