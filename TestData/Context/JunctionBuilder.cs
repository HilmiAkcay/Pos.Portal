using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Pos.EfCore
{
    public static class JunctionBuilder
    {
        public static void ArrangeJunctionTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                       .HasMany(s => s.ReleaseNumbers)
                       .WithMany(r => r.Shops)
                       .UsingEntity(junction => junction.ToTable("ShopReleaseNumber"));

            modelBuilder.Entity<ShopGroup>()
                       .HasMany(s => s.ReleaseNumbers)
                       .WithMany(r => r.ShopGroups)
                       .UsingEntity(junction => junction.ToTable("ShopGroupReleaseNumber"));
        }
    }
}
