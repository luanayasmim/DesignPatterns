namespace CursoDesignPatterns.Aula6
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }
        public IHIT() : base()  
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Itens.Distinct().Any())
                return true;

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count); 
        }
    }
}
