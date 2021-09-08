using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class Transaction : IEntity
    {
        public Guid Id { get; set; }
        public List<WalletTransaction> WalletTransactions { get; set; }
        public Guid CoinId { get; set; }
        public Coin Coin { get; set; }
        public Status Status { get; set; }
        public DateTime TransactionTime { get; set; }

    }

    public enum Status : byte
    {
        True = 1,
        False = 0
    }
}