using CloudDomain;
using Microsoft.EntityFrameworkCore;


namespace CloudData
{
    public class CloudContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<ConnectedApp> ConnectedApps { get; set; }
        public DbSet<EmailLog> EmailLogs { get; set; }
        public DbSet<EmailSetting> EmailSettings { get; set; }
        public DbSet<InstallLog> InstallLogs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<ReleaseDetail> ReleaseDetails { get; set; }
        public DbSet<ReleaseNumber> ReleaseNumbers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopSetting> ShopSettings { get; set; }
        public DbSet<ShopGroup> ShopGroups { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<StationApp> StationApps { get; set; }
        public DbSet<User> Users { get; set; }

        public CloudContext(DbContextOptions<CloudContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().HasData(
                new Application
                {
                    ID=1,
                    Name = "PurePOSGiftcardService",
                    ExeName = "Giftcard.exe",
                    IsAssignable = true,
                    StartMode = 0,
                });
        }
    }
}