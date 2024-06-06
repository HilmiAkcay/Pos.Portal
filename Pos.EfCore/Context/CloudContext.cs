using CloudDomain;
using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pos.Domain.Entities;
using Reflection = System.Reflection;


namespace Pos.EfCore.Context;

public class CloudContext : DbContext
{
    #region Entities
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

    #endregion Entities

    public CloudContext(DbContextOptions<CloudContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ArrangeJunctionTable();
        modelBuilder.InitSeed();

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(DefaultEntity).IsAssignableFrom(entityType.ClrType))
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(entityType.ClrType);
                method.Invoke(this, new object[] { modelBuilder });
            }
        }

        base.OnModelCreating(modelBuilder);
    }


    private static readonly Reflection.MethodInfo SetIsDeletedQueryFilterMethod = typeof(CloudContext)
       .GetMethod(nameof(SetIsDeletedQueryFilter), Reflection.BindingFlags.NonPublic | Reflection.BindingFlags.Static);

    private static void SetIsDeletedQueryFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : DefaultEntity
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted);
    }

    public override int SaveChanges()
    {
        HandleSoftDelete();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        HandleSoftDelete();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void HandleSoftDelete()
    {
        foreach (var entry in ChangeTracker.Entries<DefaultEntity>()
            .Where(e => e.State == EntityState.Deleted))
        {
            entry.State = EntityState.Modified;
            entry.Entity.IsDeleted = true;
            CascadeSoftDelete(entry.Entity);
        }
    }

    private void CascadeSoftDelete(DefaultEntity entity)
    {
        var entry = Entry(entity);

        foreach (var navigationEntry in entry.Navigations)
        {
            if (navigationEntry.CurrentValue is IEnumerable<DefaultEntity> collection)
            {
                foreach (var dependentEntity in collection)
                {
                    dependentEntity.IsDeleted = true;
                }
            }
            else if (navigationEntry.CurrentValue is DefaultEntity dependentEntity)
            {
                dependentEntity.IsDeleted = true;
            }
        }
    }
}
