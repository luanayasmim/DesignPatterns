namespace CursoDesignPatterns2.Aula6
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
