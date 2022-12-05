using CursoDesignPatterns2.Aula8;
using System.Xml.Serialization;

Cliente cliente = new();
cliente.Nome = "Luana";
cliente.Endereco = "Avenida Paulista";
cliente.DataNascimento = DateTime.Now;

string xml = new GeradorXml().GeraXml(cliente);

Console.WriteLine(xml);
Console.ReadKey();

/*
 * Aula 7
using CursoDesignPatterns2.Aula7;

FilaDeTrabalho fila = new();
Pedido pedido1 = new("Luana", 200);
Pedido pedido2 = new("Fernanda", 500);
Pedido pedido3 = new("Luis", 1000);

fila.Adiciona(new PagaPedido(pedido1));
fila.Adiciona(new FinalizaPedido(pedido1));

fila.Adiciona(new PagaPedido(pedido3));

fila.Processa();

Console.ReadKey();

 * Aula 6
 
using CursoDesignPatterns2.Aula6;

IMensagem mensagem = new MensagemAdministrativa("Yasmim");
mensagem.Envia();

Console.ReadKey();

 * Aula 5

using CursoDesignPatterns2.Aula5;

IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
IExpressao soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());
Impressora impressora = new Impressora();
soma.Aceita(impressora);
Console.ReadKey();



 * Aula 4

using CursoDesignPatterns2.Aula4;
using System.Linq.Expressions;

//(1+10)+(20-10)
var esquerda = new Soma(new Numero(1), new Numero(10));
var direita = new Subtracao(new Numero(20), new Numero(10));

var soma = new Soma(esquerda, direita);

soma.Avalia();

Console.WriteLine(soma.Avalia());

//Usando as expressões do c#
Expression somar = Expression.Add(Expression.Constant(10), Expression.Constant(100));
Func<int> funcao = Expression.Lambda<Func<int>>(somar).Compile();
Console.WriteLine(funcao());

Console.ReadKey();




 * Aula 3 

using CursoDesignPatterns2.Aula3;

Historico historico = new Historico();
Contrato c = new(DateTime.Now, "Luana", TipoContrato.Novo);
historico.Adicionar(c.SalvaEstado());


c.Avanca();
historico.Adicionar(c.SalvaEstado());

c.Avanca();
historico.Adicionar(c.SalvaEstado());
Console.WriteLine(c.Tipo);

Console.WriteLine(historico.Pega(2).Contrato.Tipo);





 * Aula 2
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


 * Aula 1

using CursoDesignPatterns2.Aula1;
using System.Data;

IDbConnection connection = new ConnectionFactory().GetConnection();

IDbCommand command = connection.CreateCommand();
command.CommandText = "select * from table";
*/