using ExchangeProject.Common.DataAccess;
using ExchangeProject.Common.DataAccess.EntityFramework;
using ExchangeProject.DataAccess.Abstract;
using ExchangeProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCoinRepository : EfEntityRepositoryBase<Coin>, ICoinRepository
    {
        public EfCoinRepository(DbContext context) : base(context)
        {
        }
    }
}
