namespace CursoDesignPatterns.Aula3
{
    public class Item
    {
        public String? Nome { get; private set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }


    }
}
