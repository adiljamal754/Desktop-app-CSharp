using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Csharp.Model
{
    internal class ConexaoBD
    {
        SqlConnection connection = new SqlConnection();

        //costrutor
        public ConexaoBD()
        {
            connection.ConnectionString = @"Server = DESKTOP-UD0BH2I; Database = Sistema_Hospitalar; Trusted_Connection = True";

        }

        //metodo para conectar
        public SqlConnection connect()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        //metodo para desconectar
        public void disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            
        }


    }
}
