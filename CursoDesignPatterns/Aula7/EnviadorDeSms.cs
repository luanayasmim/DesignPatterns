namespace CursoDesignPatterns.Aula7
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf) { Console.WriteLine("Simulando envio de sms"); }

    }
}
