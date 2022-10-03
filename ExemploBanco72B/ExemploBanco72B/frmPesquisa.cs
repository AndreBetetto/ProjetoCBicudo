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
    public partial class frmPesquisa : Form
    {

        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti; port=5432; " +
                "user id = projetoscti; password = gaspar";

        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = stringConexao;
            cn.Open();
            MessageBox.Show("Conectado ao banco de dados !!!!");
            CarregarFabricantes();
        }

        private void frmPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();
        }

        private void btnCarregarPesquisa_Click(object sender, EventArgs e)
        {
           // FAZER TRY E CATCH
            string sql;
            //sql = "select * from cine order by nome_fantasia";
            sql = txtSQL.Text;

            // Criar e configurar um objeto Command - responsável por
            // processar comandos SQL contra a fonte de dados
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);

            // Criar um DataAdapter do comando sql contra o banco
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            // Carregar os dados do DataAdapter para o DataSet
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgvPesquisa.DataSource = ds.Tables[0];

        }

        private void CarregarFabricantes()
        {
            string sql;
            sql = "select id_fabricante, nome from fabricante " + " order by nome";
            NpgsqlCommand cmd= new NpgsqlCommand(sql, cn);  
            NpgsqlDataAdapter da= new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbFabricantes.DataSource = dt;
            cmbFabricantes.DisplayMember = "nome";
            cmbFabricantes.ValueMember = "id_fabricante";
            cmbFabricantes.SelectedIndex = 0;

        }

        private void btnPesquisarAparelhos_Click(object sender, EventArgs e)
        {
            Int64 id_fabricante;
            id_fabricante = Convert.ToInt64(cmbFabricantes.SelectedValue);
            CarregarAparelhos(id_fabricante);
        }

        private void CarregarAparelhos(Int64 id_fabricante)
        {
            string sql;
            sql = "select * from aparelho " + "where id_fabricante = " + id_fabricante + " " + " order by modelo";
            NpgsqlCommand cmd  = new NpgsqlCommand(sql, cn);    
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPesquisa.DataSource = dt;
            dgvPesquisa.Refresh();

        }
    }
}
