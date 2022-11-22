using System.Drawing;

namespace CursoDesignPatterns.Aula5
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                descontoAplicado = true;
            }
            else
                throw new Exception("O desconto já foi aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está aprovado, não pode ser reprovado agora");

        }
    }
}
