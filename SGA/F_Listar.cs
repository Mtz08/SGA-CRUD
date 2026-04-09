using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGA
{
    public partial class F_Listar : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";

        public F_Listar()
        {
            InitializeComponent();
        }


        private void BuscarNome()
        {
            string sql = "SELECT * FROM	alunos WHERE nome LIKE  @nome";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha o campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nome", "%" + textBox1.Text + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dtgDados.DataSource = dt;
                    dtgDados.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        private void BuscarMatricula()
        {
            string sql = "SELECT * FROM	alunos WHERE matricula = @matricula";



            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha o campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@matricula", textBox1.Text);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dtgDados.DataSource = dt;
                    dtgDados.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }

        }

        private void ListarTodos()
        {
            string sql = "SELECT * FROM	alunos";

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dtgDados.DataSource = dt;
					dtgDados.Visible = true;
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbMatricula.Checked)
            {
                BuscarMatricula();

            }
            else if (rdbNome.Checked)
            {
                BuscarNome();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarTodos();
        }
    }
}
