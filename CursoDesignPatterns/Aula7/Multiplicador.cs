namespace CursoDesignPatterns.Aula7
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto*Fator);
        }
    }
}
