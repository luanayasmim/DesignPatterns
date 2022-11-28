namespace CursoDesignPatterns2.Aula4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao Numero;

        public RaizQuadrada(IExpressao numero)
        {
            Numero = numero;
        }

        public int Avalia()
        {
            int valorNumero = Numero.Avalia();
            return (int)Math.Sqrt(valorNumero);
        }
    }
}
