namespace CursoDesignPatterns.Aula7
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf) { Console.WriteLine("Simulando salvamento no banco"); }

    }
}
