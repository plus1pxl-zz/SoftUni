using Microsoft.EntityFrameworkCore;

namespace RescueRegister.Models
{
    //public class RescueRegisterDbContext : DbContext
    //{
    //    public RescueRegisterDbContext()
    //    {
    //        this.Database.EnsureCreated();
    //    }

    //    public DbSet<Mountaineer> Mountaineers { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Server=.;Database=RescueRegister;Integrated Security=True");
    //    }
    //}


    public class RescueRegisterDbContext : DbContext
    {
        public DbSet<Mountaineer> Mountaineers { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
