using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Conexao
    {
        //método para conectar no banco
        public static SqlConnection getConnection() 
        {
            //criando var cnn que armazena SqlConnection e configurando string de conexão
            SqlConnection cnn = new SqlConnection(@"Data Source=C:\Users\ismaelblck01\Documents\DB_RENTALCAR.sdf");
            //retorna valor para o método de conexao
            return cnn;
        }
    }
}
