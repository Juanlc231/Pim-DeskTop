using Pim_de_Fato.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_de_Fato.Controller
{
    public class Cadastro
    {
        //instancia da conexao ao banco de dados
        Conexao conexao = new Conexao();
        // instancia do comando Sql
        SqlCommand comando = new SqlCommand();
        

        public Cadastro(String nome, String telefone, String email, String dataN, String cnpj,String endereco, String senha)
            //Construcao de cadastro
        {
                 
            //comando sql comando
            comando.CommandText = "insert into Cadastro_do_Fornecedor(Nome_Forn,Email_Forn,DataNascimento,CNPJ,Telefone_Forn,Endereco_Forn,Senha_Forn) Values(@Nome_Form,@Email,@DataNascimento,@CNPJ,@Telefone,@Endereco,@Senha)";
            //parametros
            comando.Parameters.AddWithValue("@Nome_Form",nome);
            comando.Parameters.AddWithValue("@Email",email);
            comando.Parameters.AddWithValue("@DataNascimento", dataN);
            comando.Parameters.AddWithValue("@CNPJ", cnpj);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Senha", senha);


            try
            {
                
                //conectar ao banco
                comando.Connection = conexao.conectar();
                //executa o comando no banco de dados
                comando.ExecuteNonQuery();
                //desconecta do banco de dados
                conexao.deconectar();
                //menssagem de sucesso
                MessageBox.Show("Cadastrado com sucesso.");
            }
            catch (SqlException e)
            {
                //tratamento de erro
                MessageBox.Show("Erro ao cadastrar no Banco de Dados, necessario inserir todas as informações certa.", "ERRO DE BANCO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        } 
    }
}
