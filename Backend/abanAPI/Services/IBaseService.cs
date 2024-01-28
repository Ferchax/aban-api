using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abanAPI.Dtos;

namespace abanAPI.Services
{
    public interface IBaseService<E, T> where  T : class
    {
        public Task<ServiceResponseDto<IEnumerable<T>>> GetAll();
    }
}