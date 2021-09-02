using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class Coin : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public List<CoinPair> CoinPairs { get; set; }
        public List<AssetCoin> AssetCoins { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
