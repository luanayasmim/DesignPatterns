namespace CursoDesignPatterns.Aula6
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; private set; }
        public String CNPJ { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(string razaoSocial, string cNPJ, DateTime dataDeEmissao, 
            double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }
    }
}
