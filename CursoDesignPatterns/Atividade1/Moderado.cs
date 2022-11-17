namespace CursoDesignPatterns.Atividade1
{
    public class Moderado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            var sortear = new Random().Next(2);

            if (sortear == 1)
                return conta.Saldo * 0.25;
            else
                return conta.Saldo * 0.07;

        }
    }
}
