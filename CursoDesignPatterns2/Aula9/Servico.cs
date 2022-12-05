namespace CursoDesignPatterns2.Aula9
{
    public class Servico
    {
        enum tipos
        {
            Manutencao,
            Instalacao,
            Limpeza
        }
    }

    public class ServicoSingleton
    {
        private static Servico servico = new();

        public Servico Instancia
        {
            get { return servico; }
        }
    }
}
