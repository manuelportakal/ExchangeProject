using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class AssetCoin : IEntity
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }
        public Guid CoinId { get; set; }
        public Coin Coin { get; set; }
    }
}
