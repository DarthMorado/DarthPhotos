using AutoMapper;
using DarthPhotos.Core.Dto;
using DarthPhotos.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //        CreateMap<User, UserDto>()
            //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Email));

            CreateMap<UserDto, UserEntity>();
            CreateMap<UserEntity, UserDto>();
            
        }
    }
}
