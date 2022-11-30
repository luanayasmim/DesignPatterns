namespace CursoDesignPatterns2.Aula5
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        //private IExpressao Esquerda;
        public IExpressao Direita { get; private set; }
        //private IExpressao Direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor visitor) => visitor.ImprimeSubtracao(this);

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
