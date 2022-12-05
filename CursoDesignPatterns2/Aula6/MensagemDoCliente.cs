namespace CursoDesignPatterns2.Aula6
{
    public class MensagemDoCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemDoCliente(string nome) => this.nome = nome;


        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}
