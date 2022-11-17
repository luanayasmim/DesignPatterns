namespace CursoDesignPatterns.Atividade1
{
    public class Arrojado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            var chance = new Random().Next(101);

            if (chance <= 20)
                return conta.Saldo * 0.5;
            else if (chance > 20 && chance <= 30)
                return conta.Saldo * 0.3;
            else if (chance >= 50)
                return conta.Saldo * 0.6;

            return 0;
        }
    }
}
