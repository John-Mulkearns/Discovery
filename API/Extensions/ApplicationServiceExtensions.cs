using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using API.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public  static class ApplicationServiceExtensions    {
        
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
  
  {
         services.AddSingleton<PresenceTracker>();
         services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
 
         services.AddScoped<ITokenService, TokenService>();
         services.AddScoped<IPhotoService, PhotoService>(); 
         services.AddScoped<LogUserActivity>();

         services.AddScoped<IUserRepository, UserRepository>();
         services.AddScoped<ILikesRepository, LikesRepository>();
         services.AddScoped<IMessageRepository, MessageRepository>();
         services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
         // passing automapper a slightly oddparam that it needs to know where to find the profiles "assembly"

         services.AddDbContext<DataContext>(options => 
           {  options.UseSqlServer(config.GetConnectionString("DefaultConnection"));    });



/*
                                    services.AddDbContext<DataContext>(options =>
                                      {               options.UseSqlite(config.GetConnectionString("DefaultSQLiteConnection"));   });
                                      */
                            
        return services;

  }


    }
}