using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GameZon.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().Ignore(c=>c.EmailConfirmed);
            modelBuilder.Entity<IdentityUser>().Ignore(c=>c.PhoneNumberConfirmed);
            var AdminId = Guid.NewGuid().ToString();
            var UserId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                

                new IdentityRole()
                {
                    Id = AdminId,
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),

                },
                  new IdentityRole()
                  {
                      Id = UserId,
                      Name = "User",
                      NormalizedName = "user",
                      ConcurrencyStamp = Guid.NewGuid().ToString(),

                  }




                );
              
            

            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {

                    new Category{Id=1,Name="Sports"},
                    new Category{Id=2,Name="Actions" },
                    new Category{Id=3,Name="Adventure"},
                    new Category{Id=4,Name="Racing"},
                    new Category{Id=5,Name="Fightingfilm"},
                    new Category{Id=6,Name="Film"}


                });

            modelBuilder.Entity<Device>()
                .HasData(new Device[]
                {

                    new Device{Id=1,Name="PlayStation",Icon="bi bi-playstation"},
                    new Device{Id=2,Name="xbox" ,Icon="bi bi-xbox"},
                    new Device{Id=3,Name="Nintendo Switch",Icon="bi bi-nintendo-switch"},
                    new Device{Id=4,Name="pc",Icon="bi bi-pc-display"}

                });
            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.GameId, e.DeviceId});
            base.OnModelCreating(modelBuilder);
            
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameDevice> GameDevices { get; set; }
        public DbSet<Device> Devices { get; set; }


    }
}
