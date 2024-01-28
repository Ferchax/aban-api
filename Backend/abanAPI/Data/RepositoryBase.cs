using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;

namespace abanAPI.Data
{
    public class RepositoryBase<TEntity>(DataContext dataContext) : IRepositoryBase<TEntity> 
        where TEntity : class
    {
        private bool _disposed = false;

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Task.Run(() => dataContext.Set<TEntity>());
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await dataContext.Set<TEntity>().FindAsync(id);
        }

        public void Add(in TEntity model)
        {
            dataContext.Set<TEntity>().Add(model);
        }

         public void Update(in TEntity model)
        {
            dataContext.Entry(model).State = EntityState.Modified;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var obj = await dataContext.Set<TEntity>().FindAsync(id); 
            if (obj is { })
            {
                dataContext.Set<TEntity>().Remove(obj);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<TEntity>> SearchAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() => dataContext.Set<TEntity>().Where(predicate));
        }

        public async Task<bool> SaveAsync()
        {
            return await dataContext.SaveChangesAsync() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    dataContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}