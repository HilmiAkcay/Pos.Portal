using CloudDomain;
using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;


namespace Pos.EfCore.Context;

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
        modelBuilder.ArrangeJunctionTable();
        modelBuilder.InitSeed();
    }
}