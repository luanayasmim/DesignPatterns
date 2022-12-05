namespace CursoDesignPatterns2.Aula9
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new();

        public EmpresaFacade Instancia
        {
            get { return facade; }
        }
    }
}
