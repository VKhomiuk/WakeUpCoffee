using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Additionals",
                columns: table => new
                {
                    AdditionalId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additionals", x => x.AdditionalId);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeShops",
                columns: table => new
                {
                    CoffeeShopId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    WorkingHours = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeShops", x => x.CoffeeShopId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CoffeeShopId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_CoffeeShops_CoffeeShopId",
                        column: x => x.CoffeeShopId,
                        principalTable: "CoffeeShops",
                        principalColumn: "CoffeeShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Longitude = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Latitude = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CoffeeShopId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_CoffeeShops_CoffeeShopId",
                        column: x => x.CoffeeShopId,
                        principalTable: "CoffeeShops",
                        principalColumn: "CoffeeShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Link = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CoffeeShopId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                    table.ForeignKey(
                        name: "FK_SocialMedias_CoffeeShops_CoffeeShopId",
                        column: x => x.CoffeeShopId,
                        principalTable: "CoffeeShops",
                        principalColumn: "CoffeeShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Comment = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PaymentType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CoffeeShopId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    UserId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_CoffeeShops_CoffeeShopId",
                        column: x => x.CoffeeShopId,
                        principalTable: "CoffeeShops",
                        principalColumn: "CoffeeShopId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CookingTime = table.Column<TimeSpan>(type: "time(0)", precision: 0, nullable: false),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CategoryId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemAdditionals",
                columns: table => new
                {
                    MenuItemId = table.Column<string>(type: "varchar(36)", nullable: false),
                    AdditionalId = table.Column<string>(type: "varchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemAdditionals", x => new { x.MenuItemId, x.AdditionalId });
                    table.ForeignKey(
                        name: "FK_MenuItemAdditionals_Additionals_AdditionalId",
                        column: x => x.AdditionalId,
                        principalTable: "Additionals",
                        principalColumn: "AdditionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemAdditionals_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    OrderLineId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    MenuItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrderId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    MenuItemId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.OrderLineId);
                    table.ForeignKey(
                        name: "FK_OrderLines_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId");
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLineAdditionals",
                columns: table => new
                {
                    OrderLineId = table.Column<string>(type: "varchar(36)", nullable: false),
                    AdditionalId = table.Column<string>(type: "varchar(36)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineAdditionals", x => new { x.OrderLineId, x.AdditionalId });
                    table.ForeignKey(
                        name: "FK_OrderLineAdditionals_Additionals_AdditionalId",
                        column: x => x.AdditionalId,
                        principalTable: "Additionals",
                        principalColumn: "AdditionalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLineAdditionals_OrderLines_OrderLineId",
                        column: x => x.OrderLineId,
                        principalTable: "OrderLines",
                        principalColumn: "OrderLineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CoffeeShopId",
                table: "Categories",
                column: "CoffeeShopId");

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeShops_Email",
                table: "CoffeeShops",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CoffeeShopId",
                table: "Locations",
                column: "CoffeeShopId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemAdditionals_AdditionalId",
                table: "MenuItemAdditionals",
                column: "AdditionalId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_CategoryId",
                table: "MenuItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineAdditionals_AdditionalId",
                table: "OrderLineAdditionals",
                column: "AdditionalId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_MenuItemId",
                table: "OrderLines",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CoffeeShopId",
                table: "Orders",
                column: "CoffeeShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_CoffeeShopId",
                table: "SocialMedias",
                column: "CoffeeShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MenuItemAdditionals");

            migrationBuilder.DropTable(
                name: "OrderLineAdditionals");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Additionals");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CoffeeShops");
        }
    }
}
