namespace CursoDesignPatterns.Atividade1
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo += saldo;
        }
    }
}
