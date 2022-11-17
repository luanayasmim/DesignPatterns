namespace CursoDesignPatterns.Atividade2Correcao
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
