using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public async Task<ServiceResponseDto<IEnumerable<TDto>>> GetAllAsync()
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

        public async Task<ServiceResponseDto<TDto?>> GetByIdAsync(int id)
        {
            var serviceResponseDto = new ServiceResponseDto<TDto?>();

            try
            {
                var response = await repository.GetByIdAsync(id);
                serviceResponseDto.Data = mapper.Map<TDto>(response);
            }
            catch (Exception ex)
            {
                serviceResponseDto.Success = false;
                serviceResponseDto.Message = ex.Message;
            }

            return serviceResponseDto;
        }

        public async Task<ServiceResponseDto<IEnumerable<TDto>>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var serviceResponseDto = new ServiceResponseDto<IEnumerable<TDto>>();

            try
            {
                var response = await repository.SearchAsync(predicate);
                serviceResponseDto.Data = mapper.Map<IEnumerable<TDto>>(response);
            }
            catch (Exception ex)
            {
                serviceResponseDto.Success = false;
                serviceResponseDto.Message = ex.Message;
            }

            return serviceResponseDto;
        }

        public async Task<ServiceResponseDto<TEntity>> AddAsync(TDto model)
        {
            var serviceResponseDto = new ServiceResponseDto<TEntity>();

            try
            {
                var entity = mapper.Map<TEntity>(model);
                repository.Add(entity);
                await repository.SaveAsync();

                serviceResponseDto.Data = entity;
                serviceResponseDto.Message = "It has been added successfully.";
            }
            catch (Exception ex)
            {
                serviceResponseDto.Success = false;
                serviceResponseDto.Message = ex.Message;
            }

            return serviceResponseDto;
        }

        public async Task<ServiceResponseDto<TEntity>> UpdateAsync(TDto model)
        {
            var serviceResponseDto = new ServiceResponseDto<TEntity>();

            try
            {
                var entity = mapper.Map<TEntity>(model);
                repository.Update(entity);
                await repository.SaveAsync();

                serviceResponseDto.Data = entity;
                serviceResponseDto.Message = "It has been successfully updated.";
            }
            catch (Exception ex)
            {
                serviceResponseDto.Success = false;
                serviceResponseDto.Message = ex.Message;
            }

            return serviceResponseDto;
        }

        public async Task<ServiceResponseDto<TEntity>> RemoveAsync(int id)
        {
            var serviceResponseDto = new ServiceResponseDto<TEntity>();

            try
            {
                await repository.RemoveAsync(id);
                await repository.SaveAsync();
                serviceResponseDto.Message = "It has been successfully deleted.";
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