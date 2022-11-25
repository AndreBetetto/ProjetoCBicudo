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
    public partial class frmLogin : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti; port=5432; " +
                "user id = projetoscti; password = gaspar";

        public bool LoginOK = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            LoginOK = true;
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(LoginOK == false)
            e.Cancel = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNaoCadastrado splash = new frmNaoCadastrado();
            splash.ShowDialog();
            this.Visible = true;
        }
    }
}
