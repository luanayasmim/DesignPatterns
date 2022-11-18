﻿namespace CursoDesignPatterns.Atividade4Correcao
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMaiorQue500MilReais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Valor > 500000) filtrada.Add(c);
            }
            foreach (Conta c in OutroFiltro.Filtra(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
