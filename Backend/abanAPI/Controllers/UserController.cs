using System;
using System.Collections.Generic;
using System.Linq;
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
    //public class UserController : ControllerBase
    {
        /*[HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var userData = new {
                User = "Fernando",
                Age = "43",
                Mail = "ferchax@gmail.com" 
            };

            return Ok(userData);
        }*/

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponseDto<IEnumerable<UserDto>>>> GetAll()
        {
            var serviceResponseDto = await service.GetAll();

            if (!serviceResponseDto.Success)
            {
                return StatusCode(500, serviceResponseDto);    
            }                        

            if (serviceResponseDto.Data is null)
                return NotFound(serviceResponseDto);
                    
            return Ok(serviceResponseDto);                     
        }
    }
}