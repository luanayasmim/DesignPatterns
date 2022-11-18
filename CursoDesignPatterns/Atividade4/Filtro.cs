namespace CursoDesignPatterns.Atividade4
{
    public abstract class Filtro
    {
        public Filtro? OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }
        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta>? AdicionaOutroFiltro(IList<Conta> contas)
        {
            if (this.OutroFiltro == null)
                return null;

            return OutroFiltro.AdicionaOutroFiltro(contas);
        }
    }
}
