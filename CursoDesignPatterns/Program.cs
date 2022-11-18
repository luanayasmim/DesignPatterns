using CursoDesignPatterns.Aula4;

Imposto iss = new ISS(new ImpostoMuitoAlto(new ICMS()));

Orcamento orcamento = new(500);

double valor = iss.Calcula(orcamento);

Console.WriteLine(valor);
Console.ReadKey();