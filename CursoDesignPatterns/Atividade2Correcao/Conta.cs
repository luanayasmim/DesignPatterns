namespace CursoDesignPatterns.Atividade2Correcao
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        //public void Deposita(double valor)
        //{
        //    this.Saldo += valor;
        //}
    }
}
