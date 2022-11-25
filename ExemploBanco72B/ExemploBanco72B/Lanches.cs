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
    public partial class Lanches : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                 "database = projetoscti13; port=5432; " +
                 "user id = projetoscti13; password = 0812152830";

        public Lanches()
        {
            InitializeComponent();
        }

        public void Lanches_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = stringConexao;
            cn.Open();

            //pao
            string sqlpao;
            sqlpao = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Pão' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdpao = new NpgsqlCommand(sqlpao, cn);
            NpgsqlDataReader readerpao = cmdpao.ExecuteReader();
            DataTable dtpao = new DataTable();
            dtpao.Load(readerpao);
            DataRow rowpao = dtpao.NewRow();
            rowpao["nome"] = "Selecionar";
            dtpao.Rows.InsertAt(rowpao, 0);
            this.comboPao.DataSource = dtpao;
            this.comboPao.ValueMember = "id_item";
            this.comboPao.DisplayMember = "nome";
            readerpao.Close();
            readerpao.Dispose();
            //proteína
            string sqlpro;
            sqlpro = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Proteína' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdpro = new NpgsqlCommand(sqlpro, cn);
            NpgsqlDataReader readerpro = cmdpro.ExecuteReader();
            DataTable dtpro = new DataTable();
            dtpro.Load(readerpro);
            DataRow rowpro = dtpro.NewRow();
            rowpro["nome"] = "Selecionar";
            dtpro.Rows.InsertAt(rowpro, 0);
            this.comboPro.DataSource = dtpro;
            this.comboPro.ValueMember = "id_item";
            this.comboPro.DisplayMember = "nome";
            readerpro.Close();
            readerpro.Dispose();
            //queijo
            string sqlque;
            sqlque = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Laticínio' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdque = new NpgsqlCommand(sqlque, cn);
            NpgsqlDataReader readerque = cmdque.ExecuteReader();
            DataTable dtque = new DataTable();
            dtque.Load(readerque);
            DataRow rowque = dtque.NewRow();
            rowque["nome"] = "Selecionar";
            dtque.Rows.InsertAt(rowque, 0);
            this.comboLat.DataSource = dtque;
            this.comboLat.ValueMember = "id_item";
            this.comboLat.DisplayMember = "nome";
            readerque.Close();
            readerque.Dispose();
            //Salada
            string sqlsal;
            sqlsal = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Salada' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdsal = new NpgsqlCommand(sqlsal, cn);
            NpgsqlDataReader readersal = cmdsal.ExecuteReader();
            DataTable dtsal = new DataTable();
            dtsal.Load(readersal);
            DataRow rowsal = dtsal.NewRow();
            rowsal["nome"] = "Selecionar";
            dtsal.Rows.InsertAt(rowsal, 0);
            this.comboSal.DataSource = dtsal;
            this.comboSal.ValueMember = "id_item";
            this.comboSal.DisplayMember = "nome";
            readersal.Close();
            readersal.Dispose();
            //molho
            string sqlmol;
            sqlmol = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Molho' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdmol = new NpgsqlCommand(sqlmol, cn);
            NpgsqlDataReader readermol = cmdmol.ExecuteReader();
            DataTable dtmol = new DataTable();
            dtmol.Load(readermol);
            DataRow rowmol = dtmol.NewRow();
            rowmol["nome"] = "Selecionar";
            dtmol.Rows.InsertAt(rowmol, 0);
            this.comboMol.DataSource = dtmol;
            this.comboMol.ValueMember = "id_item";
            this.comboMol.DisplayMember = "nome";
            readermol.Close();
            readermol.Dispose();
            //Acompanhamento
            string sqlAco;
            sqlAco = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Acompanhamento' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdAco = new NpgsqlCommand(sqlAco, cn);
            NpgsqlDataReader readerAco = cmdAco.ExecuteReader();
            DataTable dtAco = new DataTable();
            dtAco.Load(readerAco);
            DataRow rowAco = dtAco.NewRow();
            rowAco["nome"] = "Sem acompanhamento";
            dtAco.Rows.InsertAt(rowAco, 0);
            this.comboAcom.DataSource = dtAco;
            this.comboAcom.ValueMember = "id_item";
            this.comboAcom.DisplayMember = "nome";
            readerAco.Close();
            readerAco.Dispose();
            //Sobremesa
            string sqlSob;
            sqlSob = "select nome, id_item, preco from lanchonete_ingredientes_adicionais where tipo = 'Sobremesa' and estoque > 0 and excluido = false";
            NpgsqlCommand cmdSob = new NpgsqlCommand(sqlSob, cn);
            NpgsqlDataReader readerSob = cmdSob.ExecuteReader();
            DataTable dtSob = new DataTable();
            dtSob.Load(readerSob);
            DataRow rowSob = dtSob.NewRow();
            rowSob["nome"] = "Sem Sobremesa";
            dtSob.Rows.InsertAt(rowSob, 0);
            this.comboSobre.DataSource = dtSob;
            this.comboSobre.ValueMember = "id_item";
            this.comboSobre.DisplayMember = "nome";
            readerSob.Close();
            readerSob.Dispose();
            //Lanche
            string sqlLan;
            sqlLan = "select nomelanche, id_lanche, preco from lanchonete_lanche where excluido = false";
            NpgsqlCommand cmdLan = new NpgsqlCommand(sqlLan, cn);
            NpgsqlDataReader readerLan = cmdLan.ExecuteReader();
            DataTable dtLan = new DataTable();
            dtLan.Load(readerLan);
            DataRow rowLan = dtLan.NewRow();
            rowLan["nomelanche"] = "Sem Lanche";
            dtLan.Rows.InsertAt(rowLan, 0);
            this.comboLanche.DataSource = dtLan;
            this.comboLanche.ValueMember = "id_lanche";
            this.comboLanche.DisplayMember = "nomelanche";
            readerLan.Close();
            readerLan.Dispose();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lanches_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            cn.Dispose();
        }

        private void btnMontar_Click(object sender, EventArgs e)
        {
            string sqlretorna;
            string sqlmonta;
            try
            {
                if (string.IsNullOrEmpty(txtNomelanche.Text))
                {
                    MessageBox.Show("Você deve dar um nome ao lanche", "Montar lanche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (comboPao.Text == "Selecionar" || comboPro.Text == "Selecionar" || comboLat.Text == "Selecionar" || comboMol.Text == "Selecionar" || comboSal.Text == "Selecionar")
                {
                    MessageBox.Show("Você deve selecionar todos os ingredientes", "Montar lanche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sqlretorna = "select id_item, nome, preco, custo from lanchonete_ingredientes_adicionais where nome = @nome1 OR nome = @nome1 OR nome = @nome2  OR nome = @nome3  OR nome = @nome4  OR nome = @nome5 and excluido = false order by tipo";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlretorna, cn);
                cmd1.Parameters.AddWithValue("@nome1", comboPao.Text);
                cmd1.Parameters.AddWithValue("@nome2", comboPro.Text);
                cmd1.Parameters.AddWithValue("@nome3", comboLat.Text);
                cmd1.Parameters.AddWithValue("@nome4", comboSal.Text);
                cmd1.Parameters.AddWithValue("@nome5", comboMol.Text);
                cmd1.ExecuteNonQuery();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvPesquisa.DataSource = ds.Tables[0];

                int preco;
                preco = Convert.ToInt16(dgvPesquisa[2, 0].Value.ToString()) + Convert.ToInt16(dgvPesquisa[2, 1].Value.ToString()) + Convert.ToInt16(dgvPesquisa[2, 2].Value.ToString()) +
                   Convert.ToInt16(dgvPesquisa[2, 3].Value.ToString()) + Convert.ToInt16(dgvPesquisa[2, 4].Value.ToString());

                int custo;
                custo = Convert.ToInt16(dgvPesquisa[3, 0].Value.ToString()) + Convert.ToInt16(dgvPesquisa[3, 1].Value.ToString()) + Convert.ToInt16(dgvPesquisa[3, 2].Value.ToString()) +
                   Convert.ToInt16(dgvPesquisa[3, 3].Value.ToString()) + Convert.ToInt16(dgvPesquisa[3, 4].Value.ToString());

                sqlmonta = "insert into lanchonete_lanche (nomelanche, laticinio, molho, proteina, pao, salada, preco, custo) "
                        + "values (@nomelanche,@lat,@mol,@pro,@pao,@sal,@preco,@custo)";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlmonta, cn);
                cmd.Parameters.AddWithValue("@nomelanche", txtNomelanche.Text);
                cmd.Parameters.AddWithValue("@lat", Convert.ToInt16(dgvPesquisa[0, 0].Value.ToString()));
                cmd.Parameters.AddWithValue("@mol", Convert.ToInt16(dgvPesquisa[0, 1].Value.ToString()));
                cmd.Parameters.AddWithValue("@pro", Convert.ToInt16(dgvPesquisa[0, 2].Value.ToString()));
                cmd.Parameters.AddWithValue("@pao", Convert.ToInt16(dgvPesquisa[0, 3].Value.ToString()));
                cmd.Parameters.AddWithValue("@sal", Convert.ToInt16(dgvPesquisa[0, 4].Value.ToString()));
                cmd.Parameters.AddWithValue("@preco", Convert.ToInt16(preco));
                cmd.Parameters.AddWithValue("@custo", Convert.ToInt16(custo));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao montar o lanche" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Montar lanche", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                string sqlLan;
                sqlLan = "select nomelanche, id_lanche, preco from lanchonete_lanche where excluido = false";
                NpgsqlCommand cmdLan = new NpgsqlCommand(sqlLan, cn);
                NpgsqlDataReader readerLan = cmdLan.ExecuteReader();
                DataTable dtLan = new DataTable();
                dtLan.Load(readerLan);
                DataRow rowLan = dtLan.NewRow();
                rowLan["nomelanche"] = "Selecionar";
                dtLan.Rows.InsertAt(rowLan, 0);
                this.comboLanche.DataSource = dtLan;
                this.comboLanche.ValueMember = "id_lanche";
                this.comboLanche.DisplayMember = "nomelanche";
                readerLan.Close();
                readerLan.Dispose();
                txtNomelanche.Text = "";
                comboLat.Text = "Selecionar";
                comboPro.Text = "Selecionar";
                comboPao.Text = "Selecionar";
                comboSal.Text = "Selecionar";
                comboMol.Text = "Selecionar";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radLanche2.Checked == true && comboLanche.Text == "Selecionar")
                {
                    MessageBox.Show("Você deve selecionar um lanche", "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (radAcom2.Checked == true && comboAcom.Text == "Selecionar")
                {
                    MessageBox.Show("Você deve selecionar um acompanahmento", "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (radSobre2.Checked == true && comboSobre.Text == "Selecionar")
                {
                    MessageBox.Show("Você deve selecionar uma sobremesa", "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string sqlretorna1;
                sqlretorna1 = "select id_item, nome, preco, custo from lanchonete_ingredientes_adicionais where nome = @nome1 OR nome = @nome2 order by tipo";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlretorna1, cn);
                cmd1.Parameters.AddWithValue("@nome1", comboSobre.Text);
                cmd1.Parameters.AddWithValue("@nome2", comboAcom.Text);
                cmd1.ExecuteNonQuery();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvPesquisa.DataSource = ds.Tables[0];
                
                string sqlretorna2;
                sqlretorna2 = "select id_lanche, nomelanche, preco, custo from lanchonete_lanche where nomelanche = @nomelanche";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sqlretorna2, cn);
                cmd2.Parameters.AddWithValue("@nomelanche", comboLanche.Text);
                cmd2.ExecuteNonQuery();
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dgvPesquisa2.DataSource = ds2.Tables[0];

                int preco;
                preco = Convert.ToInt16(dgvPesquisa[2, 0].Value.ToString()) + Convert.ToInt16(dgvPesquisa[2, 1].Value.ToString()) + Convert.ToInt16(dgvPesquisa2[2, 0].Value.ToString());

                string sqlfinaliza;
                sqlfinaliza = "insert into lanchonete_combo (lanche, acompanhamento, sobremesa, observacao, preco) "
                        + "values (@lanche,@acompanhamneto,@sobremesa,'Nenhuma.',@preco)";
                NpgsqlCommand cmd3 = new NpgsqlCommand(sqlfinaliza, cn);
                cmd3.Parameters.AddWithValue("@lanche", Convert.ToInt16(dgvPesquisa2[0, 0].Value.ToString()));
                cmd3.Parameters.AddWithValue("@acompanhamneto", Convert.ToInt16(dgvPesquisa[0, 0].Value.ToString()));
                cmd3.Parameters.AddWithValue("@sobremesa", Convert.ToInt16(dgvPesquisa[0, 1].Value.ToString()));
                cmd3.Parameters.AddWithValue("@preco", Convert.ToInt16(preco));
                cmd3.ExecuteNonQuery();
                this.Visible = false;
                Finalizacao splash = new Finalizacao();
                splash.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocorreu ao finalizar o pedido" +"\n\nMais detalhes: " + ex.Message,"Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radLanche1_CheckedChanged(object sender, EventArgs e)
        {
            if(radLanche1.Checked == true)
            {
                comboLanche.Enabled = false;
                comboLanche.Text = "Sem Lanche";
            }
            if(radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void radLanche2_CheckedChanged(object sender, EventArgs e)
        {
            if(radLanche2.Checked == true)
            {
                comboLanche.Enabled = true;
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void radAcom1_CheckedChanged(object sender, EventArgs e)
        {
            if(radAcom1.Checked == true)
            {
                comboAcom.Enabled = false;
                comboAcom.Text = "Sem acompanhamento";
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void radAcom2_CheckedChanged(object sender, EventArgs e)
        {
            if (radAcom2.Checked == true)
            {
                comboAcom.Enabled = true;
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void radSobre1_CheckedChanged(object sender, EventArgs e)
        {
            if (radSobre1.Checked == true)
            {
                comboSobre.Enabled = false;
                comboSobre.Text = "Sem Sobremesa";
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void radSobre2_CheckedChanged(object sender, EventArgs e)
        {
            if (radSobre2.Checked == true)
            {
                comboSobre.Enabled = true;
            }
            if (radLanche1.Checked == true && radAcom1.Checked == true && radSobre1.Checked == true)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtNomelanche.Text = "";
            comboLat.Text = "Selecionar";
            comboPro.Text = "Selecionar";
            comboPao.Text = "Selecionar";
            comboSal.Text = "Selecionar";
            comboMol.Text = "Selecionar";
            radLanche1.Checked = true;
            radAcom1.Checked = true;
            radSobre1.Checked = true;
        }
    }
}
