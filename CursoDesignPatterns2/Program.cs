using CursoDesignPatterns2.Aula1;
using System.Data;

IDbConnection connection = new ConnectionFactory().GetConnection();

IDbCommand command = connection.CreateCommand();
command.CommandText = "select * from table";
