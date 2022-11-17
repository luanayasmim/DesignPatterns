namespace CursoDesignPatterns.Atividade2
{
    public class Requisicao
    {
        public FormatoEnum Formato { get; private set; }

        public Requisicao(FormatoEnum formato)
        {
            this.Formato = formato; 
        }

    }
}
