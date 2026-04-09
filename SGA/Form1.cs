using System.Data;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace SGA
{
    public partial class Form1 : Form
    {
        string stringConexao = "server = localhost; database = gerenciamento; uid = root; pwd =;";

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            F_Cadastrar f = new F_Cadastrar();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            F_Listar f = new F_Listar();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            F_Atualizar f = new F_Atualizar();
            f.MdiParent = this;
            f.Show();
        }

        private void Pesquisar()
        {
            string sql = "SELECT * FROM	alunos WHERE nome LIKE  @nome";

            if (string.IsNullOrEmpty(toolStripTextBox1.Text))
            {
                MessageBox.Show("Preencha o campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nome", "%" + toolStripTextBox1.Text + "%");

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

        private void FecharTodasJanelas()
        {
            foreach (Form filho in this.MdiChildren)
            {
                filho.Close();
            }
        }

        private void ExportarTelaParaPDF()
        {
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.AddPage();

                page.Width = XUnit.FromPoint(this.Width);
                page.Height = XUnit.FromPoint(this.Height);


                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        XImage imagem = XImage.FromStream(ms);

                        gfx.DrawImage(imagem, 0, 0, page.Width, page.Height);
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", Title = "Exportar Tela" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(sfd.FileName);
                    MessageBox.Show("Exportação concluída!", "Exportar");
                }
            }
        }

        private void ExportarFormParaPDF()
        {
            Form formularioAtivo = this.ActiveMdiChild;

            if (formularioAtivo == null)
            {
                MessageBox.Show("Não há janela aberta para exportar!", "Aviso");
                return;
            }

            using (Bitmap bitmap = new Bitmap(formularioAtivo.Width, formularioAtivo.Height))
            {
                formularioAtivo.DrawToBitmap(bitmap, new Rectangle(0, 0, formularioAtivo.Width, formularioAtivo.Height));

                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.AddPage();

                page.Width = XUnit.FromPoint(formularioAtivo.Width);
                page.Height = XUnit.FromPoint(formularioAtivo.Height);

                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        XImage imagem = XImage.FromStream(ms);
                        gfx.DrawImage(imagem, 0, 0, page.Width, page.Height);
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF|*.pdf",
                    Title = "Exportar",
                    FileName = formularioAtivo.Text
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(sfd.FileName);
                    MessageBox.Show($"O formulário '{formularioAtivo.Text}' foi exportado!");
                }
            }
        }

        private void OrganizarCascata()
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void OrganizarVertical()
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void OrganizarHorizontal()
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizarCascata();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizarVertical();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizarHorizontal();
        }

        private void fecharTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodasJanelas();
        }

        private void telaCheiaParaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarTelaParaPDF();
        }

        private void formul�rioParaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarFormParaPDF();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            F_Excluir f = new F_Excluir();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
