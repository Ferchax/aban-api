using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abanAPI.Data;
using abanAPI.Dtos;
using abanAPI.Models;
using AutoMapper;

namespace abanAPI.Services
{
    public class UserService(IRepositoryBase<User> repository, IMapper mapper) : IBaseService<object?, UserDto>
    {
        public async Task<ServiceResponseDto<IEnumerable<UserDto>>> GetAll()
        {
            var serviceResponseDto = new ServiceResponseDto<IEnumerable<UserDto>>();

            try
            {
                var response = await repository.GetAllAsync();
                serviceResponseDto.Data = mapper.Map<IEnumerable<UserDto>>(response);
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