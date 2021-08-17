using System;
using System.Collections.Generic;
using DevStore.Core.DomainObjects;

namespace DevStore.Billing.API.Models
{
    public class Payment : Entity, IAggregateRoot
    {
        public Payment()
        {
            Transacoes = new List<Transaction>();
        }

        public Guid OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }

        public CreditCard CreditCard { get; set; }

        // EF Relation
        public ICollection<Transaction> Transacoes { get; set; }

        public void AdicionarTransacao(Transaction transaction)
        {
            Transacoes.Add(transaction);
        }
    }
}