namespace CursoDesignPatterns2.Aula4
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        //private IExpressao Esquerda;
        public IExpressao Direita { get; private set; }
        //private IExpressao Direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda + valorDireita;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
