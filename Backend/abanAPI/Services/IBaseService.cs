using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using abanAPI.Dtos;

namespace abanAPI.Services
{
    public interface IBaseService<E, T> where  T : class
    {
        public Task<ServiceResponseDto<IEnumerable<T>>> GetAllAsync();
        public Task<ServiceResponseDto<T?>> GetByIdAsync(int id);
        public Task<ServiceResponseDto<IEnumerable<T>>> SearchAsync(Expression<Func<E, bool>> predicate);
        Task<ServiceResponseDto<E>> AddAsync(T model);
        Task<ServiceResponseDto<E>> UpdateAsync(T model);
        Task<ServiceResponseDto<E>> RemoveAsync(int id);
    }
}