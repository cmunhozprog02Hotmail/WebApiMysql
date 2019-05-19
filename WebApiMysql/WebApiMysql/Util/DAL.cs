using MySql.Data.MySqlClient;
using System.Data;

namespace WebApiMysql.Util
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "dbcliente";
        private static string User = "root";
        private static string Password = "";
        
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;";

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        
        //Executa: INSERT, UPDATE E DELETE
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        //Retrona dados do banco
        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdapter.Fill(Dados);
            return Dados;
        }
    }
}
