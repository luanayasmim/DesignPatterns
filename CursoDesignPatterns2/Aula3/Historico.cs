namespace CursoDesignPatterns2.Aula3
{
    public class Historico
    {
        private IList<Estado> estados = new List<Estado>();

        public void Adicionar(Estado estado)
        {
            estados.Add(estado);
        }
        public Estado Pega(int indice)
        {
            return estados[indice];
        }
    }
}
