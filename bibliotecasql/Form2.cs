using biblioteca_sql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png",
                Title = "Selecione uma imagem"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteImagem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnGravaImagem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Nenhuma imagem para salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string directoryPath = "images";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string id = "default";
            string filePath = Path.Combine(directoryPath, $"{id}.jpg");

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                pictureBox1.Image.Save(filePath, ImageFormat.Jpeg);
                MessageBox.Show("Imagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                string query = "INSERT INTO Livro (titulo, idAutor, idGenero, Editora, numPaginas) VALUES (@titulo, @idAutor, @idGenero, @Editora, @numPaginas)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@titulo", txtTitulo.Text),
                    new SqlParameter("@idAutor", Convert.ToInt32(txtAutor.Text)),
                    new SqlParameter("@idGenero", Convert.ToInt32(txtgenerol.Text)),
                    new SqlParameter("@Editora", txteditora.Text),
                    new SqlParameter("@numPaginas", Convert.ToInt32(txtstock.Text))
                };

                if (DatabaseConnection.ExecuteNonQuery(query, parameters))
                {
                    MessageBox.Show("Livro adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar o livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnUpdateLivro_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                string query = "UPDATE Livro SET titulo = @titulo, idAutor = @idAutor, idGenero = @idGenero, Editora = @Editora, numPaginas = @numPaginas WHERE idLivro = @idLivro";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@titulo", txtTitulo.Text),
                    new SqlParameter("@idAutor", Convert.ToInt32(txtAutor.Text)),
                    new SqlParameter("@idGenero", Convert.ToInt32(txtgenerol.Text)),
                    new SqlParameter("@Editora", txteditora.Text),
                    new SqlParameter("@numPaginas", Convert.ToInt32(txtstock.Text)),
                    new SqlParameter("@idLivro", Convert.ToInt32(txtIdLivro.Text))
                };

                if (DatabaseConnection.ExecuteNonQuery(query, parameters))
                {
                    MessageBox.Show("Livro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnDeleteLivro_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                string query = "DELETE FROM Livro WHERE idLivro = @idLivro";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@idLivro", Convert.ToInt32(txtIdLivro.Text))
                };

                if (DatabaseConnection.ExecuteNonQuery(query, parameters))
                {
                    MessageBox.Show("Livro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DatabaseConnection.ConnectionString);
                con.Open();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Livro", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);

                dgvlivro.DataSource = dtb1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DatabaseConnection.ConnectionString);
                con.Open();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Livro", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);

                dgvlivro.DataSource = dtb1;
                con.Close();
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DatabaseConnection.conString);
                con.Open();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Livro", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);

                dgvlivro.DataSource = dtb1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
