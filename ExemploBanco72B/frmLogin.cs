using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExemploBanco72B
{
    public partial class frmLogin : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti13; port=5432; " +
                "user id = projetoscti13; password = 0812152830";

        public bool LoginOK = false;
        public bool LoginADM = false;
        private bool admin;
        private string nome;
        public frmLogin()
        {
            InitializeComponent();
            bool admin;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from lanchonete_usuario where email = @email and senha = @senha";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@email", txtUser.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    admin = reader.GetBoolean(8);
                    nome = reader.GetString(3);
                }
                if(admin == true)
                {
                    LoginADM = true;
                    MessageBox.Show("Login realizado com sucesso! Olá adm!");
                    LoginOK = true;
                    this.Visible = false;
                    frmMenu splash = new frmMenu();
                    splash.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Login realizado com sucesso! Bem vindo "+nome+"!!");
                    LoginOK = true;
                    this.Visible = false;
                    Lanches splash = new Lanches();
                    splash.ShowDialog();
                    this.Visible = true;
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Longin inválido cheque se seu e-mail e senha estão corretos");
            }

            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastro_user splash = new frmCadastro_user();
            splash.ShowDialog();
            this.Visible = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            //frmLogin login = new frmLogin();   
            //login.ShowDialog();
            this.Visible = true;
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
        }
    }
}
