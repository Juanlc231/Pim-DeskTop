using Pim_de_Fato.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pim_de_Fato.Controller
{
    public class BuscaBanco
    {
        private Conexao con; // Instância da conexão com o banco de dados
        private SqlCommand cmd;

        public BuscaBanco(Conexao con)
        {
            this.con = con;
            this.cmd = new SqlCommand(); // Inicializar o SqlCommand aqui
        }

        public List<string> ObterEmails()
        {
            List<string> emails = new List<string>();
            string query = "SELECT Email_Usuario FROM Fale_Conosco";

            cmd.CommandText = query;

            try
            {
                cmd.Connection = con.conectar();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emails.Add(reader["Email_Usuario"].ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao buscar dados no banco de dados: " + e.Message);
            }
            finally
            {
                con.deconectar(); // Fecha a conexão
            }

            return emails;
        }
    }
}
