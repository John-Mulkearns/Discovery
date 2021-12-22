using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PopulateDataStore
       {
        public static async Task SeedUsers(UserManager<AppUser> userManager, 
                                                           RoleManager<AppRole> roleManager)
        {
            if (await userManager.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            if (  users == null) return;

                var roles= new List<AppRole>{
                        new AppRole{Name="Member"},
                        new AppRole{Name="Moderator"},
                        new AppRole{Name="Admin"}
                };


                    foreach(var role in roles) {await roleManager.CreateAsync(role);}




                    foreach (var user in users)
                    {
                        user.UserName = user.UserName.ToLower();
                        await userManager.CreateAsync(user, "Pa$$w0rd");
                        await userManager.AddToRoleAsync(user, "Member");
                    }       //add checking of these methods 


                    var admin = new  AppUser
                    {
                        UserName="admin"
                    };

                                await  userManager.CreateAsync(admin, "Pa$$w0rd");
                                await userManager.AddToRolesAsync(admin, new[] {"Admin", "Moderator"});
        }
 
 
 public static async Task SeedIslands (DataContext context)
        {
            if (await context.Islands.AnyAsync()) return;

            var islandData = await System.IO.File.ReadAllTextAsync("Data/IslandSeedData.json");
            var islands = JsonSerializer.Deserialize<List<Island>>(islandData);
            if (  islands == null) return;
            foreach (var island in islands)
            {
                    island.IslandName = island.IslandName.ToLower();
                    await context.Islands.AddAsync(island);
              }
                    await context.SaveChangesAsync();
        }
 


    }
}