using AutoMapper;
using DarthPhotos.Core.Dto;
using DarthPhotos.Web.Models;

namespace DarthPhotos.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UserDto, UserModel>();
        }
    }
}
