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
                 "database = projetoscti13; port=5432; " +
                 "user id = projetoscti13; password = 0812152830";

        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = stringConexao;
            cn.Open();
            MessageBox.Show("Conectado ao banco de dados !!!!");
        }

        private void frmPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();
        }

        private void btnCarregarPesquisa_Click(object sender, EventArgs e)
        {
            try 
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar o script" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE order by estoque asc";
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Pão' order by estoque asc";
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Proteína' order by estoque asc";
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Laticínio' order by estoque asc";
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Molho' order by estoque asc";
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Salada' order by estoque asc";
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Acompanhamento' order by estoque asc";
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_item, tipo, nome, descricao, estoque, preco, custo from lanchonete_ingredientes_adicionais where excluido = FALSE and tipo = 'Sobremesa' order by estoque asc";
        }

        private void btnConsulta9_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select id_lanche, nomelanche, pao, proteina, laticinio,molho, salada, preco, custo from lanchonete_lanche where excluido = FALSE order by preco desc";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            string sql = "select null as \"Sistema aguardando script\"; ";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvPesquisa.DataSource = ds.Tables[0];
            txtSQL.Text = "";
        }
    }
}
