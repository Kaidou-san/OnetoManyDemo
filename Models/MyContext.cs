using Microsoft.EntityFrameworkCore;

namespace OtoMDemo.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        // dont forget to add ur DBSet here!!
        public DbSet<Pirate> Pirates {get; set;}
        public DbSet<Ship> Ships {get; set;}
        public DbSet<Pet> Pets {get; set;}
    }
}