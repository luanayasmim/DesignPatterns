namespace CursoDesignPatterns2.Aula4
{
    public class Subtracao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
