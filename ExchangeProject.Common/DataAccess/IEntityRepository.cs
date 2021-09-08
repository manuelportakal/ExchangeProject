using ExchangeProject.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.Common.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
