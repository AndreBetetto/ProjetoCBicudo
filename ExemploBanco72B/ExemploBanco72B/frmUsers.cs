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
using Npgsql;

namespace ExemploBanco72B
{
    public partial class frmUsers : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                 "database = projetoscti13; port=5432; " +
                 "user id = projetoscti13; password = 0812152830";
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = stringConexao;
            cn.Open();
            try
            {
                string sql;
                sql = "select * from lanchonete_usuario order by id_usuario";
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            decimal id;
            id = numericUpDown1.Value;
            try
            {
                string sql3 = "delete from lanchonete_usuario where id_usuario = " + id;
                NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, cn);

                // Criar um DataAdapter do comando sql contra o banco
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(cmd3);

                // Carregar os dados do DataAdapter para o DataSet
                DataSet ds3 = new DataSet();

                da3.Fill(ds3);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar o script" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmUsers fr = new frmUsers();
            fr.Show();
            this.Close();
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            decimal id;
            id = numericUpDown1.Value;
            try
            {
                string sql2 = "update lanchonete_usuario set excluido = true where id_usuario = " + id;
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, cn);

                // Criar um DataAdapter do comando sql contra o banco
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);

                // Carregar os dados do DataAdapter para o DataSet
                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar o script" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmUsers fr = new frmUsers();
            fr.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu fr = new frmMenu();
            fr.Show();
            this.Close();
        }
    }
}
