namespace CursoDesignPatterns.Atividade2Correcao
{
    public class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == FormatoEnum.XML)
                Console.WriteLine($"<conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo}</saldo></conta>");
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else throw new Exception("Formato de resposta não encontrado");
        }
    }
}
