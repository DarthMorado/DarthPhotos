using DarthPhotos.Core.Services;
using DarthPhotos.Db.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DarthPhotos.Core
{
    public static class ServicesConfigurator
    {
        public static void Configure(IServiceCollection services, ConfigurationManager config)
        {
            DarthPhotos.Db.ServicesConfigurator.Configure(services, config);

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IUserService, UserService>();

            
        }
    }
}
