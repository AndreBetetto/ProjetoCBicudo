﻿using System;
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
    public partial class frmCadastro_ingredientes : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string stringConexao = "server = pgsql.projetoscti.com.br;" +
                "database = projetoscti; port=5432; " +
                "user id = projetoscti; password = gaspar";

        private bool novo = false;
        public frmCadastro_ingredientes()
        {
            InitializeComponent();
        }

        private void limparForm()
        {
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            limparForm();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Voce deve preencher o campo nome do fabricante",
                        "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
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
                cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtNome.Text));
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@observacao", txtDescricao.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados do fabricante foram salvos com sucesso",
                        "Cadastro do fabricante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparForm();
                novo = false;
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao slavar os dados do fabricante" +
                    "\n\nMais detalhes: " + ex.Message,
                    "Cadastro de fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            novo = false;
            limparForm();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (!novo && string.IsNullOrEmpty(txtNome.Text))
                {
                    sql = "delete from fabricante " + "where id_fabricante - @id_fabricante";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id_fabricante", Convert.ToInt64(txtNome.Text));
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
