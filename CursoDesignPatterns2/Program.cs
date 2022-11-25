using CursoDesignPatterns2.Aula2;

NotasMusicais notas = new NotasMusicais();

IList<INota> musica = new List<INota>()
{
    notas.Get("do"),
    notas.Get("re"),
    notas.Get("mi"),
    notas.Get("fa"),
    notas.Get("fa"),
    notas.Get("fa")
};

Piano piano = new Piano();

piano.Tocar(musica);

/*
 * Aula 1


using CursoDesignPatterns2.Aula1;
using System.Data;

IDbConnection connection = new ConnectionFactory().GetConnection();

IDbCommand command = connection.CreateCommand();
command.CommandText = "select * from table";
*/