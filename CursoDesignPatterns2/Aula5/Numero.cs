namespace CursoDesignPatterns2.Aula5
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }
        //private int numero;

        public Numero(int numero) => Valor = numero;

        public int Avalia() => Valor;

        public void Aceita(IVisitor visitor) => visitor.ImprimeNumero(this);
    }
}
