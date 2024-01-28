using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abanAPI.Data;
using abanAPI.Dtos;
using AutoMapper;

namespace abanAPI.Services
{
    public class BaseService<TEntity, TDto>(
        IRepositoryBase<TEntity> repository,
        IMapper mapper) 
    : IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        public async Task<ServiceResponseDto<IEnumerable<TDto>>> GetAll()
        {
            var serviceResponseDto = new ServiceResponseDto<IEnumerable<TDto>>();

             try
            {
                var response = await repository.GetAllAsync();
                serviceResponseDto.Data = mapper.Map<IEnumerable<TDto>>(response);
            }
            catch (Exception ex)
            {
                serviceResponseDto.Success = false;
                serviceResponseDto.Message = ex.Message;                
            }            

            return serviceResponseDto;
        }
    }
}