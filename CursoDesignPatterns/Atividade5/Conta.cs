namespace CursoDesignPatterns.Atividade5
{
    public class Conta
    {
        public double Saldo { get; private set; }

        interface IEstadoDaConta
        {
            void Saca(Conta c, double valor);
            void Deposita(Conta c, double valor);
        }
        class Positivo : IEstadoDaConta
        {
            public void Saca(Conta c, double valor) { c.Saldo -= valor; }
            public void Deposita(Conta c, double valor) { c.Saldo += valor; }
        }
    }
}
