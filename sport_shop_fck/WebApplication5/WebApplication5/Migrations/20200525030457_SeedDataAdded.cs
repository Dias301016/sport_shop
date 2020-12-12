using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    VendorCode = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsGoodOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodId);
                    table.ForeignKey(
                        name: "FK_Goods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "GoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "GoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Kits", null },
                    { 2, "Sport shoes", null },
                    { 3, "Paraphernalia", null },
                    { 4, "Sport bags", null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsGoodOfTheWeek", "LongDescription", "Name", "Price", "VendorCode" },
                values: new object[,]
                {
                    { 1, 1, "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg", "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg", true, true, "This model is perfect for sports, it can also be used as a casual sports-style T-shirt or for outdoor recreation. The T-shirt has modern Dri-FIT technology, the essence of the technology is the use of special fibers woven into the fabric, these fibers on the one hand absorb moisture that is released by the body during training, take it out, where evaporation occurs.", " Nike ACADEMY16 SS TOP (SP16)", 20.93m, "725932 - 739" },
                    { 2, 1, "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg", "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg", true, true, "The yellow Nike Striker IV T - shirt is a great choice for outdoor sports in cool weather.", "NIKE LS STRIKER IV JSY (SP16)", 22.15m, "725885-739" },
                    { 3, 1, "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg", "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg", true, true, "This model sits comfortably on the body during training, does not interfere with freedom of movement and provides convenience for the athlete's body. Good ventilation qualities of the jersey provide the necessary amount of fresh air for the body of a football player. In the production of the material, modern Dri-FIT technology is used, which absorbs moisture from the surface of the body, transfers it to the outer layer, where it evaporates, which ensures comfortable dry conditions.", "NIKE SS STIKER IV JSY", 20.25m, "725892-739" },
                    { 4, 1, "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg", "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg", false, false, "Dri-FIT technology helps remove moisture and provides comfort. A collar with a V-neck and piping does not rub the skin. Mesh inserts on the back provide extra ventilation. Raglan cut sleeves without a shoulder seam do not constrain movements. Swoosh logo is embroidered on the right chest.", "Nike Striped Division III SS", 35.99m, "894081-739" },
                    { 5, 2, "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg", true, false, "Football boots NIKE MERCURIAL VAPOR XI CR7 AG-PRO 878647-001 SR professional model for synthetic grass fields. The boots are part of the CR7 Chapter 4: Forged For Greatness name collection, created with the participation of world football star Cristiano Ronaldo and dedicated to his brilliant career. Boots received updated colors. The sole and the edge of the upper in contact with it have a gradient, orange color, which turns into a metallic, gray color of the upper. The coloring evokes associations with the molten metal from which the mold is created.", "NIKE MERCURIAL VAPOR XI CR7 AG-PRO", 72.16m, "878647-001 SR" },
                    { 6, 2, "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg", true, false, "Professional-grade model for synthetic grass fields. The boots are part of the Just Do It Pack collection, created specifically for the 2018 FIFA World Cup. The back of the boot is decorated with a triangle made of thirty-two lines. Just so many teams will take part in the 2018 World Cup. The boots have a great fit, comfort, flexibility, give the player a great ball feel thanks to their all-cut top, which is made of Flyknit woven material. A thin layer of NikeSkin polyurethane mesh, which covers the surface of the boot, gives added density and precision to the fit.", "NIKE VAPOR XII ELITE AG-PRO", 135.99m, "AH7379-107 SR" },
                    { 7, 2, "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg", true, false, "A semi-professional model from the Just Do It Pack collection, which was created specifically for the 2018 World Cup. Cleats are designed for dry, natural, grassy lawns. The hybrid top combines kangaroo leather in its design, which during processing maintains its natural structure and elasticity, and Flyknit synthetic material, which is used in the back of the top and for the inner tongue. This ensures an ideal, tight and comfortable fit, excellent breathability and lightweight boots.", "NIKE LEGEND VII PRO FG", 120.95m, "AH7241-107 SR" },
                    { 9, 3, "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg", true, false, "Match Pennant for game Kairat-AZ ALKMAAR", "Pennant Kairat - Alkmar", 120.5m, "13121010" },
                    { 10, 3, "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg", true, false, "Gift badge in metal box", "FC Kairat gift badge", 12.95m, "03112017" },
                    { 11, 3, "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg", "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg", true, false, "Suitcase tee on a suction cup with the club logo", "Souvenir T-shirt", 9.95m, "1539" },
                    { 8, 4, "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg", "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg", true, false, "The bag has one large central compartment in which you can conveniently transport sportswear and accessories. The bag is sewn of dense fabric, polyester, which has a woven structure, which provides high wear resistance, the fabric is resistant to mechanical stress, it does not tear and does not deform. The material is water-repellent, which protects the contents from getting wet during transport. The model has a size, the bottom is 16.1 (41 cm) x 9 (23 cm), the height of the bag is 9 (23 cm).", "NIKE BAG BA51", 22.37m, "BA5185 - 010" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_CategoryId",
                table: "Goods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_GoodId",
                table: "OrderDetails",
                column: "GoodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_GoodId",
                table: "ShoppingCartItems",
                column: "GoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
