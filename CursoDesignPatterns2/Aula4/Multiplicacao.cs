namespace CursoDesignPatterns2.Aula4
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorDireita * valorDireita;
        }
    }
}
