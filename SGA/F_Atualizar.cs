using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;

namespace SGA
{
    public partial class F_Atualizar : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";

        public F_Atualizar()
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

        private void Atualizar()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text) || string.IsNullOrEmpty(maskedTextBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Informe qual o número de matrícula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MailAddress m = new MailAddress(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Digite um E-mail Válido!", " ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string sql = "UPDATE alunos SET nome = @nome, nascimento = @nascimento, cpf = @cpf, telefone = @telefone, endereco = @endereco, email = @email WHERE  matricula = @matricula";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConexao))
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", textBox1.Text);
                    comando.Parameters.AddWithValue("@nascimento", maskedTextBox2.Text);
                    comando.Parameters.AddWithValue("@cpf", maskedTextBox3.Text);
                    comando.Parameters.AddWithValue("@telefone", maskedTextBox1.Text);
                    comando.Parameters.AddWithValue("@matricula", textBox4.Text);
                    comando.Parameters.AddWithValue("@endereco", textBox2.Text);
                    comando.Parameters.AddWithValue("@email", textBox3.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Atualizado com Sucesso!");
                    conexao.Close();
                    textBox1.Text = ""; maskedTextBox1.Text = ""; maskedTextBox2.Text = ""; maskedTextBox3.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar: ", ex.Message);
                return;
            }
            Carregar();
            textBox4.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
			// Verifica se a tecla pressionada não é número, nem backspace
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				// Define Handled como true para cancelar o pressionamento da tecla
				e.Handled = true;
			}
		}
    }
}
