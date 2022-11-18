namespace CursoDesignPatterns.Atividade4
{
    public class SaldoMaiorQue500Mil : Filtro
    {
        public SaldoMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public SaldoMaiorQue500Mil() : base()
        {
        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
