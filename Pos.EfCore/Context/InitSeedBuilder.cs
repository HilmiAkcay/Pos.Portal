using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Pos.EfCore
{
    public static class InitSeedBuilder
    {
        public static void InitSeed(this ModelBuilder modelBuilder)
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
                    CTime = DateTime.Now,
                    IsDeleted = false,
                    MTime = DateTime.Now,
                    Name = "Default Group",
                });
            modelBuilder.Entity<Shop>().HasData(
                new Shop
                {
                    ID = 1,
                    CTime = DateTime.Now,
                    IsDeleted = false,
                    MTime = DateTime.Now,
                    Name = "Default Shop",
                    ShopGroupId = 1,
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    CTime = DateTime.Now,
                    Email = "admin@posmanager.nl",
                    IsDeleted = false,
                    IsValidated = true,
                    MTime = DateTime.Now,
                    Password = "PoS666",
                    RememberMe = true,
                    ShopId = 1,
                });
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   ID = 2,
                   CTime = DateTime.Now,
                   Email = "admin",
                   IsDeleted = false,
                   IsValidated = true,
                   MTime = DateTime.Now,
                   Password = "1",
                   RememberMe = true,
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
