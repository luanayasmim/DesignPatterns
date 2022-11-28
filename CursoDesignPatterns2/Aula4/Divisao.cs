namespace CursoDesignPatterns2.Aula4
{
    public class Divisao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}
