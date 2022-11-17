namespace CursoDesignPatterns.Atividade2Correcao
{
    public class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == FormatoEnum.PORCENTO)
                Console.WriteLine($"{conta.Titular} % {conta.Saldo}");
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else throw new Exception("Formato de resposta não encontrado");
        }
    }
}
