using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions options) : base(options){}
     
        public DbSet<AppUser> Users {get; set;}

        public DbSet<Island> Islands{get; set;}

    }
}   




// public DataContext(DbContextOptions<DataContext> options)  : base(options) {}