namespace CursoDesignPatterns2.Aula4
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }
        //private int numero;

        public Numero(int numero)
        {
            Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
