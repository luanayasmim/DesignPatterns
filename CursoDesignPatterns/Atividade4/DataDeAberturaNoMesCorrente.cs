namespace CursoDesignPatterns.Atividade4
{
    public class DataDeAberturaNoMesCorrente : Filtro
    {
        public DataDeAberturaNoMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public DataDeAberturaNoMesCorrente() : base()
        {
        }


        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
