namespace CursoDesignPatterns.Aula6
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, TemplateDeImpostoCondicional imposto)
        {
            var resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
