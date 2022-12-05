namespace CursoDesignPatterns2.Aula7
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            pedido.Paga();
            Console.WriteLine("Pagando o pedido do cliente {0}", pedido.Cliente);
        }
    }
}
