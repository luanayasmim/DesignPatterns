using CursoDesignPatterns.Aula2;

CalculadorDeDescontos calculador = new();
Orcamento orcamento = new(500);

orcamento.AdicionaItem(new Item("Lápis", 250));
orcamento.AdicionaItem(new Item("Caneta", 250));
//orcamento.AdicionaItem(new Item("Monitor", 250));
//orcamento.AdicionaItem(new Item("Headphone", 250));
//orcamento.AdicionaItem(new Item("MousePad", 250));
//orcamento.AdicionaItem(new Item("Livro", 250));

double desconto = calculador.Calcula(orcamento);
Console.WriteLine(desconto);