using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBanco72B
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            frmLogin login = new frmLogin();   
            login.ShowDialog();
            this.Visible=true;
        }

        private void btnCad_Ingre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastro_ingredientes splash = new frmCadastro_ingredientes();
            splash.ShowDialog();
            this.Visible = true;
        }

        private void btnCad_user_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastro_user splash = new frmCadastro_user();
            splash.ShowDialog();
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Visible = true;
        }

        private void btnScripts_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisa splash = new frmPesquisa();
            splash.ShowDialog();
            this.Visible = true;
        }
    }
}
