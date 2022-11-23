namespace CursoDesignPatterns.Aula7
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de e-mail");
        }
    }
}
