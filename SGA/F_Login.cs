using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace SGA
{
    public partial class F_Login : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";
        string resultado;

        public F_Login()
        {
            InitializeComponent();
        }



        private void Cadastrar()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Preencha todos os campos!!");
                return;
            }

            try
            {
                MailAddress m = new MailAddress(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Formato de e-mail inválido!!");
                return;
            }



            try
            {
                resultado = BCrypt.Net.BCrypt.HashPassword(textBox4.Text);

                using (MySqlConnection conexao = new MySqlConnection(stringConexao))
                {
                    string sql = "INSERT INTO usuarios (login, senha) VALUES (@login, @senha)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@login", textBox3.Text.Trim());
                    comando.Parameters.AddWithValue("@senha", resultado.Trim());

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Efetuado!");
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: ", ex.Message);
                return;
            }
            pnlCadastrar.Visible = false;
        }

        private void Entrar()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos!!");
                return;
            }

            string loginDigitado = textBox1.Text;
            string senhaDigitada = textBox2.Text;
            string hash = "";


            string query = "SELECT Senha FROM usuarios WHERE Login = @Login";

            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Login", loginDigitado);

                conexao.Open();
                var validade = comando.ExecuteScalar();

                if (validade != null)
                {
                    hash = validade.ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!");
                    return;
                }
            }


            bool valido = BCrypt.Net.BCrypt.Verify(senhaDigitada, hash);

            if (valido)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCadastrar.Visible=false;
        }
    }
}
