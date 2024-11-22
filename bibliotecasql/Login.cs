using biblioteca_sql;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bibliotecasql
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsernameLogin.Select();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre a conexão com o banco de dados antes de executar a consulta
                DatabaseConnection.OpenConnection();

                // Define a consulta com parâmetros
                string query = "SELECT * FROM Leitores WHERE login = @login";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@login", txtUsernameLogin.Text)
                };

                // Executa a consulta
                SqlDataReader reader = DatabaseConnection.ExecuteQuery(query, parameters);

                if (reader != null && reader.HasRows)
                {
                    reader.Read();  // Lê a primeira linha

                    // Recupera a senha criptografada do banco
                    string encryptedPassword = reader["password"].ToString();

                    // Descriptografa a senha armazenada
                    string decryptedPassword = CryptoHelper.Decrypt(encryptedPassword);

                    // Compara a senha inserida com a senha descriptografada
                    if (txtPasswordLogin.Text == decryptedPassword)
                    {
                        MessageBox.Show("Login bem-sucedido!");
                        // Código adicional para navegação
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }

                reader?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtUsernameRegisto.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordRegisto.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPasswordRegisto.Text) ||
                string.IsNullOrWhiteSpace(txtMoradaRegisto.Text) ||
                string.IsNullOrWhiteSpace(txtNomeRegisto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifica se a senha e a confirmação são iguais
            if (txtPasswordRegisto.Text != txtConfirmPasswordRegisto.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            try
            {
                // Criptografa a senha
                string encryptedPassword = CryptoHelper.Encrypt(txtPasswordRegisto.Text);

                // Abre a conexão com o banco de dados
                DatabaseConnection.OpenConnection();

                // Define a consulta SQL com parâmetros
                string query = "INSERT INTO Leitores (nome, morada, login, password) VALUES (@nome, @morada, @login, @password)";

                // Cria os parâmetros e define seus valores
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@nome", txtNomeRegisto.Text),
            new SqlParameter("@morada", txtMoradaRegisto.Text),
            new SqlParameter("@login", txtUsernameRegisto.Text),
            new SqlParameter("@password", encryptedPassword)
                };

                // Executa o comando e verifica o resultado
                bool success = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (success)
                {
                    MessageBox.Show("Registro realizado com sucesso!");
                    // Limpa os campos após o registro
                    txtUsernameRegisto.Clear();
                    txtPasswordRegisto.Clear();
                    txtConfirmPasswordRegisto.Clear();
                    txtMoradaRegisto.Clear();
                    txtNomeRegisto.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o registro. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnshow_pass_Click(object sender, EventArgs e)
        {
            // Verifica o estado atual e alterna entre exibir ou ocultar a senha
            if (txtPasswordLogin.UseSystemPasswordChar) // Se a senha estiver oculta
            {
                txtPasswordLogin.UseSystemPasswordChar = false; // Torna a senha visível
                btnshow_pass.BackgroundImage = Properties.Resources.eyes_none; // Imagem de olho aberto
            }
            else // Se a senha já estiver visível
            {
                txtPasswordLogin.UseSystemPasswordChar = true; // Torna a senha oculta
                btnshow_pass.BackgroundImage = Properties.Resources.eyes; // Imagem de olho fechado
            }
        }





        private void btnshow_pass_registo_Click(object sender, EventArgs e)
        {
            // Verifica o estado atual e alterna entre exibir ou ocultar a senha
            if (txtPasswordRegisto.UseSystemPasswordChar) // Se a senha estiver oculta
            {
                txtPasswordRegisto.UseSystemPasswordChar = false; // Torna a senha visível
                btnshow_pass_registo.BackgroundImage = Properties.Resources.eyes_none; // Imagem de olho aberto
            }
            else // Se a senha já estiver visível
            {
                txtPasswordRegisto.UseSystemPasswordChar = true; // Torna a senha oculta
                btnshow_pass_registo.BackgroundImage = Properties.Resources.eyes; // Imagem de olho fechado
            }
        }

        private void btnshow_confirmpass_registo_Click(object sender, EventArgs e)
        {
            // Verifica o estado atual e alterna entre exibir ou ocultar a senha
            if (txtConfirmPasswordRegisto.UseSystemPasswordChar) // Se a senha estiver oculta
            {
                txtConfirmPasswordRegisto.UseSystemPasswordChar = false; // Torna a senha visível
                btnshow_confirmpass_registo.BackgroundImage = Properties.Resources.eyes_none; // Imagem de olho aberto
            }
            else // Se a senha já estiver visível
            {
                txtConfirmPasswordRegisto.UseSystemPasswordChar = true; // Torna a senha oculta
                btnshow_confirmpass_registo.BackgroundImage = Properties.Resources.eyes; // Imagem de olho fechado
            }
        }
    }
}