using CloudDomain;
using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;


namespace CloudData
{
    public class CloudContext : DbContext
    {
        public DbSet<Application> Application { get; set; }
        public DbSet<AppSetting> AppSetting { get; set; }
        public DbSet<ConnectedApp> ConnectedApp { get; set; }
        public DbSet<EmailLog> EmailLog { get; set; }
        public DbSet<EmailSetting> EmailSetting { get; set; }
        public DbSet<InstallLog> InstallLog { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<ReleaseDetail> ReleaseDetail { get; set; }
        public DbSet<ReleaseNumber> ReleaseNumber { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<ShopSetting> ShopSetting { get; set; }
        public DbSet<ShopGroup> ShopGroup { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<StationApp> StationApp { get; set; }
        public DbSet<User> User { get; set; }

        public CloudContext(DbContextOptions<CloudContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().HasData(
                new Application
                {
                    ID = 1,
                    Name = "PurePOSGiftcardService",
                    ExeName = "Giftcard.exe",
                    IsAssignable = true,
                    StartMode = 0,
                });
            modelBuilder.Entity<ShopGroup>().HasData(
                new ShopGroup
                {
                    ID = 1,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    ModifiedDate = DateTime.Now,
                    Name = "Default Group",
                    UID = Guid.NewGuid(),
                });
            modelBuilder.Entity<Shop>().HasData(
                new Shop
                {
                    ID = 1,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    ModifiedDate = DateTime.Now,
                    Name = "Default Shop",
                    UID = Guid.NewGuid(),
                    ShopGroupId = 1,
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    CreatedDate = DateTime.Now,
                    Email = "admin@posmanager.nl",
                    IsDeleted = false,
                    IsValidated = true,
                    ModifiedDate = DateTime.Now,
                    Password = "PoS666",
                    RememberMe = true,
                    UID = Guid.NewGuid(),
                    ShopId = 1,
                });

            Page page = new Page()
            {
                ID = 1,
                Name = "Users",
                PurePosId = 2
            };

            modelBuilder.Entity<Page>().HasData(page);

            page = new Page()
            {
                ID = 3,
                Name = "User Setting",
                PurePosId = 3
            };

            modelBuilder.Entity<Page>().HasData(page);


        }
    }
}