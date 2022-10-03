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
    public partial class frmCad_fabricante : Form
    {

        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti; port=5432; " +
                "user id = projetoscti; password = gaspar";

        private bool novo = false;
        public frmCad_fabricante()
        {
            InitializeComponent();
        }

        private void btnCarregarPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void frmCad_fabricante_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = stringConexao;
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectear ao banco" + 
                    "\n\nMais detalhes: " + ex.Message,  
                    "Cadastro de fabricantes" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
            }
        }

        private void frmCad_fabricante_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCad_fabricante_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();  
        }

        private void btnSlavar_Click(object sender, EventArgs e)
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
                if (novo)
                {
                    sql = "insert into fabricante (id_fabricante, nome, observacao) " + "values (@id_fabricante, @nome, @observacao)";
                }
                else
                {
                    sql = "update fabricante set " +
                        "nome = @nome, " +
                        "observacao = @observacao " +
                        "where id_fabricante = @id_fabricante";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtIdfabricante.Text));
                cmd.Parameters.AddWithValue("@nome", txtNone.Text);
                cmd.Parameters.AddWithValue("@observacao", txtObs.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados do fabricante foram salvos com sucesso",
                        "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparForm();
                novo = false;
                txtIdfabricante.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao slavar os dados do fabricante" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Cadastro de fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limparForm()
        {
            txtIdfabricante.Clear();
            txtNone.Clear();
            txtObs.Clear();
        }

        private void txtIdfabricante_Validated(object sender, EventArgs e)
        {

        }

        private void txtIdfabricante_Validating(object sender, CancelEventArgs e)
        {
            string sql;
            try
            {
                if(!string.IsNullOrEmpty(txtIdfabricante.Text))
                { 
                sql = "select * from fabricante where id_fabricante = @id_fabricante";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtIdfabricante.Text));
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtNone.Text = dr["nome"].ToString();
                        txtObs.Text = dr["observacao"].ToString();
                        novo = false;
                    }
                    else 
                    {
                        if (!novo)
                        {
                            MessageBox.Show("ID do fabricante nao encontrado", "Cadastro de fabricantes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparForm();
                            e.Cancel = true;
                        }
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao pesquisar os dados do fabricante" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Cadastro de fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            limparForm();
            txtIdfabricante.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            novo = false;
            limparForm();
            txtIdfabricante.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if(!novo && string.IsNullOrEmpty(txtIdfabricante.Text))
                {
                    sql = "delete from fabricante " + "where id_fabricante - @id_fabricante";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtIdfabricante.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados do fabricante foram excluidos com sucesso",
                            "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparForm();
                    novo = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir os dados do fabricante" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Cadastro de fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
