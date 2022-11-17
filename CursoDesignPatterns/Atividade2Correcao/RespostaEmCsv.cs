namespace CursoDesignPatterns.Atividade2Correcao
{
    public class RespostaEmCsv : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == FormatoEnum.CSV)
                Console.WriteLine($"{conta.Titular}; {conta.Saldo}");
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else throw new Exception("Formato de resposta não encontrado");
        }
    }
}
