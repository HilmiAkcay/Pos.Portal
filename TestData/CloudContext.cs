using CloudDomain;
using Microsoft.EntityFrameworkCore;

namespace TestData
{
    public class CloudContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<ConnectedApp> ConnectedApps { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<ReleaseDetail> ReleaseDetails { get; set; }
        public DbSet<ReleaseNumber> ReleaseNumbers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopGroup> ShopGroups { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<StationApp> StationApps { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=PosCloudDB;User ID=sa;Password=Hi044603");
        }
    }
}