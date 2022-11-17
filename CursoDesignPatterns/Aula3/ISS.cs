namespace CursoDesignPatterns.Aula3
{
    public class ISS : TemplateDeImpostoCondicional
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
