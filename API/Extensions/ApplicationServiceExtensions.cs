using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public  static class ApplicationServiceExtensions    {
        
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
  
  {

 
         services.AddScoped<ITokenService, TokenService>();
         
         services.AddScoped<IUserRepository, UserRepository>();
         services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
         // passing automapper a slightly odd looking param that it needs to know where to find the profiles "assembly"

         services.AddDbContext<DataContext>(options => 
           {  options.UseSqlServer(config.GetConnectionString("DefaultConnection"));    });

          services.AddDbContext<DataContext>(options =>
            {               options.UseSqlite(config.GetConnectionString("DefaultSQLiteConnection"));   });
                             return services;
  }


    }
}