namespace CursoDesignPatterns.Aula3
{
    public class ICMS : TemplateDeImpostoCondicional
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
