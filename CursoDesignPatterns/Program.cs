using CursoDesignPatterns.Aula3;

var icpp = new ICPP();

Orcamento orcamento = new(500);

Console.WriteLine(icpp.Calcula(orcamento));

Console.ReadKey();