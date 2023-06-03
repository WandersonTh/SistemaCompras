using SistemaCompra.Domain.Core;
using System;
using System.Collections.Generic;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public class CondicaoPagamento
    {
        private IList<int> _valoresPossiveis = new List<int>() { 0, 30, 60, 90 };
        public int Valor { get; private set; }

        private CondicaoPagamento(){}

        public CondicaoPagamento(int condicao, decimal totalGeral)
        {
            if (totalGeral > 5000)
                condicao = 30;

            if (!_valoresPossiveis.Contains(condicao)) throw new BusinessRuleException("Condição de pagamento deve ser " +_valoresPossiveis.ToString());

            Valor = condicao;
        }
    }
}