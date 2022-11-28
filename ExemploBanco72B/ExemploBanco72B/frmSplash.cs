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
    public partial class frmSplash: Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                 "database = projetoscti13; port=5432; " +
                 "user id = projetoscti13; password = 0812152830";
        public frmSplash()
        {
            InitializeComponent();
        }

        private async void frmSplash_Load(object sender, EventArgs e)
        {
           try
           {
                int contagem = 0;
                do
                {
                    await Task.Delay(30);
                    pgbCarrega.Value++;
                    contagem++;
                } while (contagem < 100);
                cn.ConnectionString = stringConexao;
                cn.Open();

                string sql3;
                sql3 = "update lanchonete_ingredientes_adicionais set estoque = estoque + 100 where estoque < 100";
                NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, cn);
                cmd3.ExecuteNonQuery();

                this.Close();
           }catch (Exception ex)
            {
                MessageBox.Show("Ocorreu  um erro ao inicializar o sistema" + "\n\nMais detalhes: " + ex.Message, "Iniciar sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();
        }

       
    }
}
