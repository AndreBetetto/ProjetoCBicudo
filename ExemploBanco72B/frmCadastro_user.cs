using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ExemploBanco72B
{
    public partial class frmCadastro_user : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti13; port=5432; " +
                "user id = projetoscti13; password = 0812152830";

        public frmCadastro_user()
        {
            InitializeComponent();
        }

        private void limparForm()
        {
            txtNone.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
            txtCSenha.Clear(); 
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (string.IsNullOrEmpty(txtNone.Text))
                {
                    MessageBox.Show("Voce deve preencher o campo nome do fabricante",
                        "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNone.Focus();
                    return;
                }
                 sql = "insert into lanchonete_usuario (cpf, email, nome, datanasc, cep, telefone, senha, adm) " + "values (@cpf, @email, @nome, current_timestamp, @cep, @telefone, @senha, @adm)";                 
               


                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@nome", txtNone.Text);
                cmd.Parameters.AddWithValue("@datanasc", "2000-01-01");
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                if (radAdmsim.Checked == true)
                    cmd.Parameters.AddWithValue("@adm", true);
                else
                    cmd.Parameters.AddWithValue("@adm", false);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados do fabricante foram salvos com sucesso",
                        "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparForm();
                txtCPF.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao slavar os dados do fabricante" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Cadastro de fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparForm();
            txtCPF.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastro_user_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = stringConexao;
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar com o Banco de Dados !!!" +
                                    "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Fabricantes",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //this.BackColor = Color.FromArgb(0, 48, 73);
            //this.lblCSenha.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblAdm.ForeColor = Color.FromArgb(247, 127, 0);
            //this.label1.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblCEP.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblCPF.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblDataNasc.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblEmail.ForeColor = Color.FromArgb(247, 127, 0);
            //this.lblSenha.ForeColor = Color.FromArgb(247, 127, 0);
            //this.label3.ForeColor = Color.FromArgb(247, 127, 0);
        }
    }
}
