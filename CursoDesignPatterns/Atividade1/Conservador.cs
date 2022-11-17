namespace CursoDesignPatterns.Atividade1
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Conta conta)
        {

            return conta.Saldo * 0.008;
        }
    }
}
