using System.Data;
using System.Data.SqlClient;

namespace CursoDesignPatterns2.Aula1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "String de conexão";
            //connection.ConnectionString = new ConfigReader().ReadConnectionString();
            connection.Open();

            return connection;
        }
    }
}
