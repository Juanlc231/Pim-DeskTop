using Pim_de_Fato.Model;
using Pim_de_Fato.View;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pim_de_Fato.Controller
{
    public class Login
    {
        Conexao cone = new Conexao(); // Classe de conexão
        SqlCommand cmd = new SqlCommand(); // Classe de comando SQL
        int con = 0;    

        public void Logi(string nome, string email, string senha) // Construção do login
        {


            string query = "SELECT Nome_Forn, Email_Forn, Senha_Forn FROM Cadastro_do_Fornecedor WHERE Nome_Forn = @nome AND Email_Forn = @email AND Senha_Forn = @senha"; //Comando a ser execuatdo no banco

            try
            {
                cmd.Connection = cone.conectar(); // Conecta ao banco de dados
                cmd.CommandText = query;

                // Adicionando os parâmetros de forma segura
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                SqlDataReader reader = cmd.ExecuteReader(); // Executa a consulta e retorna um SqlDataReader

                // Verifica se encontrou algo
                if (reader.HasRows)
                {
                    MessageBox.Show("Cadastro feito com sucesso, Bem-vindo!"); // messagem caso o login seja feito de maneira certa
                    con++;
                }
                else
                {
                    MessageBox.Show("Usuário, senha ou email incorretos. Tente novamente.", "Falha no Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation); //menssagem caso o login seja encontrado no banco de dados 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar login: {ex.Message}", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error); //menssagem de erro no banco de dados
            }
            finally
            {
                cone.deconectar(); // Desconecta do banco
            }
        }
        public bool Val() // valida se a busca foi feita com sucesso
        {
            if (con >= 0)
            {
                return true;
            }
            else return false;
        }
    }
}
