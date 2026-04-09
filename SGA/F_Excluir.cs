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
    public partial class F_Excluir : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";

        public F_Excluir()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            string sql = "SELECT * FROM	alunos WHERE matricula =  @matricula";

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Preencha o campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@matricula", textBox4.Text);

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

        private void Excluir()
        {
            string sql = "DELETE FROM alunos WHERE matricula = @matricula";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConexao))
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@matricula", Convert.ToInt32(textBox4.Text));
					cmd.ExecuteNonQuery();                                                                    

					MessageBox.Show("Aluno deletado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
            Carregar();

        }

        private void Carregar()
        {
            string sql = "SELECT * FROM	alunos WHERE matricula = @matricula";

            using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
            {
                da.SelectCommand.Parameters.AddWithValue("@matricula", textBox4.Text);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dtgDados.DataSource = dt;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
