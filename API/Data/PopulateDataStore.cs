using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PopulateDataStore
       {
        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            if (  users == null) return;
            foreach (var user in users)
            {
                 //    using var hmac = new HMACSHA512();
                user.UserName = user.UserName.ToLower();
                  //  user.PasswordSalt = hmac.Key;
                  //  user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));

                await context.Users.AddAsync(user);
            }
                await context.SaveChangesAsync();
        }
 
 
 public static async Task SeedIslands (DataContext context)
        {
            if (await context.Islands.AnyAsync()) return;

            var islandData = await System.IO.File.ReadAllTextAsync("Data/IslandSeedData.json");
            var islands = JsonSerializer.Deserialize<List<Island>>(islandData);
            if (  islands == null) return;
            foreach (var island in islands)
            {
                 //    using var hmac = new HMACSHA512();
                island.IslandName = island.IslandName.ToLower();
                  //  user.PasswordSalt = hmac.Key;
                  //  user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));

                await context.Islands.AddAsync(island);
            }
                await context.SaveChangesAsync();
        }
 


    }
}