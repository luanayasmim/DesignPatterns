namespace CursoDesignPatterns.Atividade4
{
    public class SaldoMenorQue100Reais : Filtro
    {
        public SaldoMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public SaldoMenorQue100Reais() : base()
        {
        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
