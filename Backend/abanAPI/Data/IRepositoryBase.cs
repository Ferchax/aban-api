using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace abanAPI.Data
{
    public interface IRepositoryBase<T> : IDisposable 
        where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> SearchAsync(Expression<Func<T, bool>> predicate);
        void Add(in T model);
        void Update(in T model);
        Task<bool> RemoveAsync(int id);
        Task<bool> SaveAsync();
    }
}