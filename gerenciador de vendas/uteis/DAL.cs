using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace gerenciador_de_vendas.uteis
{
    public class DAL
    {
        private static string server = "localhost";
        private static string Database = "sistema_venda";
        private static string user = "root";
        private static string password = "";
        private static string conectionString = $"server={server};Database={Database};Uid={user};Pwd{password};Sslmode=none;Charset=utf8;";
        private static MySqlConnection Connection;

        public DAL()
        {
            Connection = new MySqlConnection(conectionString);
            Connection.Open();
        }

        public DataTable conDataTable (string sql)
        {
            DataTable data = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(data);
            return data;
        }
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand command = MySqlCommand(sql, Connection);


        }


    }
    
     

}
      