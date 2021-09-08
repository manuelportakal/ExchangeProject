using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Entities.Concrete
{
    public class Pair : IEntity
    {
        public Guid Id { get; set; }
        public List<CoinPair> CoinPairs { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}