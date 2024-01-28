using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abanAPI.Dtos;
using abanAPI.Models;
using AutoMapper;

namespace abanAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();    
        }
        
    }
}