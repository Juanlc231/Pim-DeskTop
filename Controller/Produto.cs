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
    public class Produto
    {
        //instanciando a conexao com o banco
        Conexao con = new Conexao();
        //instanciando o comando sql
        SqlCommand coman = new SqlCommand();
        

        public Produto(String nomeP, String cate,  Double quantidade, Double valor, String descricao)
        {
            //comando de insert
            coman.CommandText = "insert into Produto(Nome_Produto,CatePd, ValorPD,QuantPD,Descricao_Produt) Values(@Produto, @Categoria ,@Valor,@Quantidade,@descricao)";
            //parametros 

            
            coman.Parameters.AddWithValue("@Produto", nomeP);
            coman.Parameters.AddWithValue("@Categoria", cate);
            coman.Parameters.AddWithValue("@Valor", valor);
            coman.Parameters.AddWithValue("@Quantidade", quantidade);
            coman.Parameters.AddWithValue("@descricao", descricao);

            try
            {
                //Conecta com o banco 
                coman.Connection = con.conectar();
                //executa o comando no banco de dados
                coman.ExecuteNonQuery();
                //desconecta do banco
                con.deconectar();
                MessageBox.Show("Cadastro realizado com sucesso.");


            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao cadastrar no banco de dados" + e);
            }
        }
    }
}
