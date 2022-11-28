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
    public partial class Finalizacao : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                 "database = projetoscti13; port=5432; " +
                 "user id = projetoscti13; password = 0812152830";
        public Finalizacao()
        {
            InitializeComponent();
        }
        private void Finalizacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();
        }

        private void Finalizacao_Load_1(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = stringConexao;
                cn.Open();
                string sql;
                sql = "select lanche, acompanhamento, sobremesa, preco from lanchonete_combo order by id_combo desc limit 1";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvPesquisa.DataSource = ds.Tables[0];
                txtLanche.Text = dgvPesquisa[0, 0].Value.ToString();
                txtAcompanhamento.Text = dgvPesquisa[1, 0].Value.ToString();
                txtSobremesa.Text = dgvPesquisa[2, 0].Value.ToString();
                txtTotal.Text = dgvPesquisa[3, 0].Value.ToString();

                string sql2;
                sql2 = "select nomelanche, preco from lanchonete_lanche where id_lanche = @nomelanche";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, cn);
                cmd2.Parameters.AddWithValue("@nomelanche", Convert.ToInt16(txtLanche.Text));
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dgvPesquisa.DataSource = ds2.Tables[0];
                txtLanche.Text = dgvPesquisa[0, 0].Value.ToString();
                txtPlanche.Text = dgvPesquisa[1, 0].Value.ToString();

                string sql3;
                sql3 = "select nome, preco from lanchonete_ingredientes_adicionais where id_item = @nomeacompanhamento";
                NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, cn);
                cmd3.Parameters.AddWithValue("@nomeacompanhamento", Convert.ToInt16(txtAcompanhamento.Text));
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                dgvPesquisa.DataSource = ds3.Tables[0];
                txtAcompanhamento.Text = dgvPesquisa[0, 0].Value.ToString();
                txtPacompanhamento.Text = dgvPesquisa[1, 0].Value.ToString();

                string sql4;
                sql4 = "select nome, preco from lanchonete_ingredientes_adicionais where id_item = @nomesobremesa";
                NpgsqlCommand cmd4 = new NpgsqlCommand(sql4, cn);
                cmd4.Parameters.AddWithValue("@nomesobremesa", Convert.ToInt16(txtSobremesa.Text));
                NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(cmd4);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4);
                dgvPesquisa.DataSource = ds4.Tables[0];
                txtSobremesa.Text = dgvPesquisa[0, 0].Value.ToString();
                txtPsobremesa.Text = dgvPesquisa[1, 0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao finalizar o pedido" + "\n\nMais detalhes: " + ex.Message, "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "select lanche, acompanhamento, bebida, sobremesa from lanchonete_combo order by id_combo desc limit 1";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvPesquisa.DataSource = ds.Tables[0];
                string idlanche = dgvPesquisa[0, 0].Value.ToString();
                string id6 = dgvPesquisa[1, 0].Value.ToString();
                string id7 = dgvPesquisa[2, 0].Value.ToString();
                string id8 = dgvPesquisa[3, 0].Value.ToString();

                string sql2;
                sql2 = "select pao, proteina, laticinio, molho, salada from lanchonete_lanche where id_lanche = @idlanche";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, cn);
                cmd2.Parameters.AddWithValue("@idlanche", Convert.ToInt16(idlanche));
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dgvPesquisa.DataSource = ds2.Tables[0];
                string id1 = dgvPesquisa[0, 0].Value.ToString();
                string id2 = dgvPesquisa[1, 0].Value.ToString();
                string id3 = dgvPesquisa[2, 0].Value.ToString();
                string id4 = dgvPesquisa[3, 0].Value.ToString();
                string id5 = dgvPesquisa[4, 0].Value.ToString();

                string sql3;
                sql3 = "update lanchonete_ingredientes_adicionais set estoque = estoque - 1 where id_item = @1 OR id_item = @2 OR id_item = @3 OR id_item = @4 OR id_item = @5 OR id_item = @6 OR id_item = @7 OR id_item = @8";
                NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, cn);
                cmd3.Parameters.AddWithValue("@1", Convert.ToInt16(id1));
                cmd3.Parameters.AddWithValue("@2", Convert.ToInt16(id2));
                cmd3.Parameters.AddWithValue("@3", Convert.ToInt16(id3));
                cmd3.Parameters.AddWithValue("@4", Convert.ToInt16(id4));
                cmd3.Parameters.AddWithValue("@5", Convert.ToInt16(id5));
                cmd3.Parameters.AddWithValue("@6", Convert.ToInt16(id6));
                cmd3.Parameters.AddWithValue("@7", Convert.ToInt16(id7));
                cmd3.Parameters.AddWithValue("@8", Convert.ToInt16(id8));
                cmd3.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu  um erro ao finalizar o pedido" + "\n\nMais detalhes: " + ex.Message, "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
