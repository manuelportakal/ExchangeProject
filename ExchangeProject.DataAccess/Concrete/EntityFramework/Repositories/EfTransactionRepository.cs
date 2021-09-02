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
    public class EfTransactionRepository : EfEntityRepositoryBase<Transaction>, ITransactionRepository
    {
        public EfTransactionRepository(DbContext context) : base(context)
        {
        }
    }
}
