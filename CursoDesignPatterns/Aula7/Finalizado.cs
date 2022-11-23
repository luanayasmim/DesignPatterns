﻿namespace CursoDesignPatterns.Aula7
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos Finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");

        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");

        }
    }
}
