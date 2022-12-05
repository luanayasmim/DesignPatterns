namespace CursoDesignPatterns2.Aula7
{
    public class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            pedido.Finaliza();
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
        }
    }
}
