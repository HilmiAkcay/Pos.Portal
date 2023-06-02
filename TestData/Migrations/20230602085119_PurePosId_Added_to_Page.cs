using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudData.Migrations
{
    public partial class PurePosId_Added_to_Page : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartMode = table.Column<int>(type: "int", nullable: false),
                    StartAfterInstall = table.Column<bool>(type: "bit", nullable: false),
                    IsAssignable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppSetting",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSetting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmailSetting",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnableSSL = table.Column<bool>(type: "bit", nullable: false),
                    TimeOut = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSetting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<long>(type: "bigint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Expanded = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPack = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurePosId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseNumber",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseNumber", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShopGroup",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModulePage",
                columns: table => new
                {
                    ModulesID = table.Column<long>(type: "bigint", nullable: false),
                    PagesID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulePage", x => new { x.ModulesID, x.PagesID });
                    table.ForeignKey(
                        name: "FK_ModulePage_Module_ModulesID",
                        column: x => x.ModulesID,
                        principalTable: "Module",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulePage_Page_PagesID",
                        column: x => x.PagesID,
                        principalTable: "Page",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseDetail",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseNumberId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    PageId = table.Column<long>(type: "bigint", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReleaseDetail_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseDetail_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseDetail_ReleaseNumber_ReleaseNumberId",
                        column: x => x.ReleaseNumberId,
                        principalTable: "ReleaseNumber",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopSetting",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<long>(type: "bigint", nullable: false),
                    LicenseExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailSettingId = table.Column<long>(type: "bigint", nullable: false),
                    ConcurrentBoCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrentFoCount = table.Column<int>(type: "int", nullable: false),
                    DatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultReportId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopSetting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShopSetting_EmailSetting_EmailSettingId",
                        column: x => x.EmailSettingId,
                        principalTable: "EmailSetting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopSetting_Report_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Report",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    MenusID = table.Column<long>(type: "bigint", nullable: false),
                    RolesID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => new { x.MenusID, x.RolesID });
                    table.ForeignKey(
                        name: "FK_MenuRole_Menu_MenusID",
                        column: x => x.MenusID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRole_Role_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseNumberShopGroup",
                columns: table => new
                {
                    ReleaseNumbersID = table.Column<long>(type: "bigint", nullable: false),
                    ShopGroupsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseNumberShopGroup", x => new { x.ReleaseNumbersID, x.ShopGroupsID });
                    table.ForeignKey(
                        name: "FK_ReleaseNumberShopGroup_ReleaseNumber_ReleaseNumbersID",
                        column: x => x.ReleaseNumbersID,
                        principalTable: "ReleaseNumber",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseNumberShopGroup_ShopGroup_ShopGroupsID",
                        column: x => x.ShopGroupsID,
                        principalTable: "ShopGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shop_ShopGroup_ShopGroupId",
                        column: x => x.ShopGroupId,
                        principalTable: "ShopGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailLog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmailLog_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseNumberShop",
                columns: table => new
                {
                    ReleaseNumbersID = table.Column<long>(type: "bigint", nullable: false),
                    ShopsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseNumberShop", x => new { x.ReleaseNumbersID, x.ShopsID });
                    table.ForeignKey(
                        name: "FK_ReleaseNumberShop_ReleaseNumber_ReleaseNumbersID",
                        column: x => x.ReleaseNumbersID,
                        principalTable: "ReleaseNumber",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseNumberShop_Shop_ShopsID",
                        column: x => x.ShopsID,
                        principalTable: "Shop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportShop",
                columns: table => new
                {
                    ReportsID = table.Column<long>(type: "bigint", nullable: false),
                    ShopsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportShop", x => new { x.ReportsID, x.ShopsID });
                    table.ForeignKey(
                        name: "FK_ReportShop_Report_ReportsID",
                        column: x => x.ReportsID,
                        principalTable: "Report",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportShop_Shop_ShopsID",
                        column: x => x.ShopsID,
                        principalTable: "Shop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Station_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopId = table.Column<long>(type: "bigint", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false),
                    IsValidated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectedApp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    StationId = table.Column<long>(type: "bigint", nullable: false),
                    IsConnected = table.Column<bool>(type: "bit", nullable: false),
                    ConnectionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectedApp", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConnectedApp_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectedApp_Station_StationId",
                        column: x => x.StationId,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstallLog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    StartMode = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallLog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InstallLog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstallLog_Station_StationId",
                        column: x => x.StationId,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationApp",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    StationId = table.Column<long>(type: "bigint", nullable: false),
                    StartMode = table.Column<int>(type: "int", nullable: false),
                    StartAfterInstall = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationApp", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StationApp_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationApp_Station_StationId",
                        column: x => x.StationId,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesID = table.Column<long>(type: "bigint", nullable: false),
                    UsersID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "ID", "CreatedDate", "ExeName", "IsAssignable", "IsDeleted", "ModifiedDate", "Name", "StartAfterInstall", "StartMode", "UID" },
                values: new object[] { 1L, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(6866), "Giftcard.exe", true, false, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(6877), "PurePOSGiftcardService", false, 0, new Guid("2c95d909-87bf-4260-9456-416be57aff04") });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "ID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name", "PurePosId", "UID" },
                values: new object[] { 1L, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7098), false, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7099), "Users", 2, new Guid("bfd9ecb4-9f37-4b0d-8418-932766396070") });

            migrationBuilder.InsertData(
                table: "ShopGroup",
                columns: new[] { "ID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name", "UID" },
                values: new object[] { 1L, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7038), false, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7040), "Default Group", new Guid("0ffb52f5-6ff4-4ba8-b4c4-63a9d375652a") });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name", "ShopGroupId", "UID" },
                values: new object[] { 1L, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7071), false, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7073), "Default Shop", 1L, new Guid("3a0521dd-db52-4db3-9fe2-bebd2c844516") });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CreatedDate", "Email", "IsDeleted", "IsValidated", "ModifiedDate", "Password", "RememberMe", "ShopId", "UID" },
                values: new object[] { 1L, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7091), "admin@posmanager.nl", false, true, new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7093), "PoS666", true, 1L, new Guid("1bb31986-b56c-4a62-9aae-5956d659092d") });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectedApp_ApplicationId",
                table: "ConnectedApp",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectedApp_StationId",
                table: "ConnectedApp",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailLog_ShopId",
                table: "EmailLog",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallLog_ApplicationId",
                table: "InstallLog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_InstallLog_StationId",
                table: "InstallLog",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RolesID",
                table: "MenuRole",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePage_PagesID",
                table: "ModulePage",
                column: "PagesID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseDetail_ApplicationId",
                table: "ReleaseDetail",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseDetail_PageId",
                table: "ReleaseDetail",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseDetail_ReleaseNumberId",
                table: "ReleaseDetail",
                column: "ReleaseNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseNumberShop_ShopsID",
                table: "ReleaseNumberShop",
                column: "ShopsID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseNumberShopGroup_ShopGroupsID",
                table: "ReleaseNumberShopGroup",
                column: "ShopGroupsID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportShop_ShopsID",
                table: "ReportShop",
                column: "ShopsID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersID",
                table: "RoleUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_ShopGroupId",
                table: "Shop",
                column: "ShopGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopSetting_EmailSettingId",
                table: "ShopSetting",
                column: "EmailSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopSetting_ReportID",
                table: "ShopSetting",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Station_ShopId",
                table: "Station",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_StationApp_ApplicationId",
                table: "StationApp",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_StationApp_StationId",
                table: "StationApp",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ShopId",
                table: "User",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSetting");

            migrationBuilder.DropTable(
                name: "ConnectedApp");

            migrationBuilder.DropTable(
                name: "EmailLog");

            migrationBuilder.DropTable(
                name: "InstallLog");

            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "ModulePage");

            migrationBuilder.DropTable(
                name: "ReleaseDetail");

            migrationBuilder.DropTable(
                name: "ReleaseNumberShop");

            migrationBuilder.DropTable(
                name: "ReleaseNumberShopGroup");

            migrationBuilder.DropTable(
                name: "ReportShop");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "ShopSetting");

            migrationBuilder.DropTable(
                name: "StationApp");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "ReleaseNumber");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "EmailSetting");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "ShopGroup");
        }
    }
}
