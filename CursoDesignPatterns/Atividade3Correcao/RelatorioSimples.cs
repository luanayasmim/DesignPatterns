namespace CursoDesignPatterns.Atividade3Correcao
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Bradesco");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"{conta.Nome} - {conta.Saldo}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 4002-8922");
        }
    }
}
