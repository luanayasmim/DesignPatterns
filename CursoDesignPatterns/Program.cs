using CursoDesignPatterns.Aula1;

IImposto iss = new ISS();
IImposto icms = new ICMS();

Orcamento orcamento = new(500);
CalculadorDeImpostos calculador = new();
calculador.RealizaCalculo(orcamento, iss);