using CloudDomain.Domain;
using Microsoft.EntityFrameworkCore;
using Pos.EfCore.Seeds;

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
                  StartMode = Domain.Enums.EnumServiceStartMode.Manual
              });

            modelBuilder.Entity<Application>().HasData(
            new Application
            {
                ID = 2,
                Name = "PccService",
                ExeName = "PosCloudConnector.exe",
                IsAssignable = true,
                StartMode = Domain.Enums.EnumServiceStartMode.Automatic,
            });
            modelBuilder.Entity<Application>().HasData(
            new Application
            {
                ID = 3,
                Name = "PosSyncService",
                ExeName = "DbSyncConsole.exe",
                IsAssignable = true,
                StartMode = Domain.Enums.EnumServiceStartMode.Manual,
            });

            modelBuilder.Entity<Application>().HasData(
            new Application
            {
                ID = 4,
                Name = "PurePOSCommissionService",
                ExeName = "PosCommissionService.exe",
                IsAssignable = true,
                StartMode = Domain.Enums.EnumServiceStartMode.Manual,
            });

            modelBuilder.Entity<Application>().HasData(
           new Application
           {
               ID = 5,
               Name = "PurePOSScheduleService",
               ExeName = "PosScheduleService.exe",
               IsAssignable = true,
               StartMode = Domain.Enums.EnumServiceStartMode.Manual,
           });

            modelBuilder.Entity<ShopGroup>().HasData(
                new ShopGroup
                {
                    ID = 1,
                    CTime = DateTime.Now.ToUniversalTime(),
                    IsDeleted = false,
                    MTime = DateTime.Now.ToUniversalTime(),
                    Name = "Default Group",
                });
            modelBuilder.Entity<Shop>().HasData(
                new Shop
                {
                    ID = 1,
                    CTime = DateTime.Now.ToUniversalTime(),
                    IsDeleted = false,
                    MTime = DateTime.Now.ToUniversalTime(),
                    Name = "Default Shop",
                    ShopGroupId = 1,
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    CTime = DateTime.Now.ToUniversalTime(),
                    Email = "admin@posmanager.nl",
                    IsDeleted = false,
                    IsValidated = true,
                    MTime = DateTime.Now.ToUniversalTime(),
                    Password = "PoS666",
                    RememberMe = true,
                    ShopId = 1,
                });
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   ID = 2,
                   CTime = DateTime.Now.ToUniversalTime(),
                   Email = "admin",
                   IsDeleted = false,
                   IsValidated = true,
                   MTime = DateTime.Now.ToUniversalTime(),
                   Password = "1",
                   RememberMe = true,
                   ShopId = 1,
               });

            PageSeed pageSeed = new PageSeed();
            pageSeed.Seed(modelBuilder);
        }
    }
}
