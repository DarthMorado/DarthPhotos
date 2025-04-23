using DarthPhotos.Db.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Db
{
    public static class ServicesConfigurator
    {
        public static void Configure(IServiceCollection services, ConfigurationManager config)
        {
            services.AddDbContext<Database>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
