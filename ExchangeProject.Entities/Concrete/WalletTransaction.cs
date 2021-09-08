using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class WalletTransaction : IEntity
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public TransactionRole TransactionRole { get; set; }
        public decimal Amount { get; set; }
    }

    public enum TransactionRole : ushort
    {
        Sender = 1,
        Receiver = 2
    }
}