namespace CursoDesignPatterns.Atividade3Correcao
{
    class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Santader");
            Console.WriteLine("Avenida Brasil, n° 666");
            Console.WriteLine("(19) 4002-8922");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"{conta.Nome} - {conta.Numero} - {conta.Agencia} - {conta.Saldo}");
            }
        }

        protected override void Rodape()
        {
            throw new NotImplementedException();
        }
    }
}
