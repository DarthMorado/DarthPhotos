using AutoMapper;
using DarthPhotos.Core.Dto;
using DarthPhotos.Db.Entities;
using DarthPhotos.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Services
{
    public interface IUserService
    {
        public Task<UserDto> GetUserBasicInfoAsync(string gmail, CancellationToken cancellationToken);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        

        public UserService(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> GetUserBasicInfoAsync(string gmail, CancellationToken cancellationToken)
        {
            UserEntity user = await _userRepository.GetByEmailAsync(gmail, cancellationToken);
            if (user == null)
            {
                var userEntity = new UserEntity()
                {
                    Gmail = gmail,
                    IsAdmin = false
                };

                await _userRepository.CreateAsync(userEntity);
            }

            return _mapper.Map<UserDto>(user);
        }
    }
}
