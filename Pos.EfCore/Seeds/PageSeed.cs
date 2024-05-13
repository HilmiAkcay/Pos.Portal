using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.EfCore.Seeds
{
    internal class PageSeed : ISeed
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 1, PurePosId = 1, Name = "Settings (Category)" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 2, PurePosId = 2, Name = "Users" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 3, PurePosId = 3, Name = "User Settings" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 4, PurePosId = 6, Name = "Company" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 5, PurePosId = 7, Name = "Company Region" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 6, PurePosId = 8, Name = "Shop" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 7, PurePosId = 9, Name = "Warehouse" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 8, PurePosId = 10, Name = "Product Management" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 9, PurePosId = 11, Name = "Brand" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 10, PurePosId = 12, Name = "Model" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 11, PurePosId = 13, Name = "Season" });
            modelBuilder.Entity<Page>().HasData(new Page() { ID = 12, PurePosId = 18, Name = "Vat" });

        }
    }
}
