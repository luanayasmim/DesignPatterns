namespace CursoDesignPatterns.Atividade1
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaCalculo(Conta conta, IInvestimento investimento)
        {
            double valor = investimento.Calcula(conta);
        }
    }
}
