namespace CursoDesignPatterns2.Aula2
{
    public class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.WriteLine(nota);
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}
