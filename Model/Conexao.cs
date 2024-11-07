using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_de_Fato.Model
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();
        //Construçso 
        public Conexao()
        {
            //caminho para o banco de dados
            conexao.ConnectionString = "Data Source=JBNOOTBOOK\\SQLEXPRESS;Initial Catalog=\"Fazenda Cant Verd\";Integrated Security=True;Encrypt=False"; //camminho para o banco de dados
            
        }
       
        //metodos conectar
        public SqlConnection conectar ()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        //metodo desconectar
        public void deconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}
