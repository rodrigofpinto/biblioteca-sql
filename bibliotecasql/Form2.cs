using biblioteca_sql;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO; // Namespace correto para manipulação de arquivos e diretórios
using System.Windows.Forms;

namespace bibliotecasql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddImagem_Click(object sender, EventArgs e)
        {
            // Criar diálogo para seleção de arquivo
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png",
                Title = "Selecione uma imagem"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carregar a imagem no PictureBox
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                catch (Exception ex)
                {
                    // Mostrar mensagem de erro em caso de falha
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteImagem_Click(object sender, EventArgs e)
        {
            // Remover imagem do PictureBox
            pictureBox1.Image = null;
        }

        private void btnGravaImagem_Click(object sender, EventArgs e)
        {
            // Verificar se há uma imagem no PictureBox
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Nenhuma imagem para salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar pasta "images" se não existir
            string directoryPath = "images";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Definir o nome do arquivo (substitua `id` pelo valor apropriado)
            string id = "default"; // Você pode alterar o valor do id conforme necessário
            string filePath = Path.Combine(directoryPath, $"{id}.jpg");

            try
            {
                // Verificar se o arquivo já existe e excluí-lo
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Salvar a imagem como JPEG
                pictureBox1.Image.Save(filePath, ImageFormat.Jpeg);

                MessageBox.Show("Imagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensagem de erro em caso de falha
                MessageBox.Show($"Erro ao salvar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            DatabaseConnection.OpenConnection(); 
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-M12AA0DA; Initial Catalog=biblioteca; Integrated Security=True; Encrypt=False; TrustServerCertificate=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO [dbo].[Livro] (titulo, idAutor, idGenero, Editora, numPaginas) " +
                               "VALUES (@titulo, @idAutor, @idGenero, @Editora, @numPaginas)";

                SqlCommand sql = new SqlCommand(query, con);

                // Evitar SQL Injection
                sql.Parameters.AddWithValue("@titulo", txtitulo.Text);
                sql.Parameters.AddWithValue("@idAutor", txtautorl.Text);
                sql.Parameters.AddWithValue("@idGenero", txtgenerol.Text);
                sql.Parameters.AddWithValue("@Editora", txteditora.Text);
                sql.Parameters.AddWithValue("@numPaginas", txtstock.Text);

                try
                {
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Livro Adicionado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar livro: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
