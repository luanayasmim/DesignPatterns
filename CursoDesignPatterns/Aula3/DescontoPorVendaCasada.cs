namespace CursoDesignPatterns.Aula3
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconta(orcamento);
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("Caneta", orcamento) && Existe("Lápis", orcamento);
        }

        private bool Existe(String nomeItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem))
                    return true;
            }
            return false;
        }
    }
}
