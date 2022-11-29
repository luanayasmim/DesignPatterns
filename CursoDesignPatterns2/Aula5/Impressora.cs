namespace CursoDesignPatterns2.Aula5
{
    public class Impressora
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write($"(");
            subtracao.Esquerda.Aceita(this);
            Console.Write($"-");
            subtracao.Direita.Aceita(this); 
            Console.Write($")");
        }
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
