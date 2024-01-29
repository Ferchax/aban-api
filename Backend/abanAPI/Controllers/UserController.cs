using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using abanAPI.Data;
using abanAPI.Dtos;
using abanAPI.Models;
using abanAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace abanAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController(IBaseService<User, UserDto> service) : ControllerBase
    {
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponseDto<IEnumerable<UserDto>>>> GetAll()
        {
            var serviceResponseDto = await service.GetAllAsync();

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);
        }

        [HttpGet]
        [Route("Get/{id}")]
        public async Task<ActionResult<ServiceResponseDto<UserDto>>> Get(int id)
        {
            var serviceResponseDto = await service.GetByIdAsync(id);

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);
        }

        [HttpGet("Search")]
        public async Task<ActionResult<ServiceResponseDto<IEnumerable<UserDto>>>> Search(string search)
        {            
            Expression<Func<User, bool>> predicate = u => 
            u.Nombres.Contains(search.Trim())
            || u.Apellidos.Contains(search.Trim())
            || u.Cuit != null && u.Cuit.Contains(search.Trim())
            || u.Domicilio != null && u.Domicilio.Contains(search.Trim())
            || u.Celular != null && u.Celular.Contains(search.Trim())
            || u.Email.Contains(search.Trim());

             var serviceResponseDto = await service.SearchAsync(predicate);

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult<ServiceResponseDto<UserDto>>> Insert(UserDto userDto)
        {
            var serviceResponseDto = await service.AddAsync(userDto);

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);
        }

        [HttpPost("Update")]
        public async Task<ActionResult<ServiceResponseDto<UserDto>>> Update(UserDto userDto)
        {
            var serviceResponseDto = await service.UpdateAsync(userDto);

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<ServiceResponseDto<UserDto>>> Delete(int id)
        {
            var serviceResponseDto = await service.RemoveAsync(id);

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }
                    
            return Ok(serviceResponseDto);
        }
    }
}