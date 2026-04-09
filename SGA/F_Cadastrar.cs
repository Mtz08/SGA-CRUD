using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;

namespace SGA
{
    public partial class F_Cadastrar : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";

        public F_Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text) || string.IsNullOrEmpty(maskedTextBox3.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            try
            {

                using (MySqlConnection conexao = new MySqlConnection(stringConexao))
                {
                    string sql = "INSERT INTO alunos (nome, nascimento, cpf, telefone, endereco, email) VALUES (@nome, @nascimento, @cpf, @telefone, @endereco, @email)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@nascimento", maskedTextBox2.Text.Trim());
                    comando.Parameters.AddWithValue("@cpf", maskedTextBox3.Text.Trim());
                    comando.Parameters.AddWithValue("@telefone", maskedTextBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@endereco", textBox2.Text.Trim());
                    comando.Parameters.AddWithValue("@email", textBox3.Text.Trim());

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Efetuado!");
                    conexao.Close();
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; maskedTextBox1.Text = ""; maskedTextBox2.Text = ""; maskedTextBox3.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: ", ex.Message);
                return;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
