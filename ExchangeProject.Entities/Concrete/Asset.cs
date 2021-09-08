using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class Asset : IEntity
    {
        public Guid Id { get; set; }
        public Guid CoinId { get; set; }
        public Coin Coin { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public decimal Amount { get; set; }
    }
}
