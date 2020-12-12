﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5.Models;

namespace WebApplication5.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200525030457_SeedDataAdded")]
    partial class SeedDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication5.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kits"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Sport shoes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Paraphernalia"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Sport bags"
                        });
                });

            modelBuilder.Entity("WebApplication5.Models.Good", b =>
                {
                    b.Property<int>("GoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGoodOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VendorCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            GoodId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg",
                            InStock = true,
                            IsGoodOfTheWeek = true,
                            LongDescription = "This model is perfect for sports, it can also be used as a casual sports-style T-shirt or for outdoor recreation. The T-shirt has modern Dri-FIT technology, the essence of the technology is the use of special fibers woven into the fabric, these fibers on the one hand absorb moisture that is released by the body during training, take it out, where evaporation occurs.",
                            Name = " Nike ACADEMY16 SS TOP (SP16)",
                            Price = 20.93m,
                            VendorCode = "725932 - 739"
                        },
                        new
                        {
                            GoodId = 2,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = true,
                            LongDescription = "The yellow Nike Striker IV T - shirt is a great choice for outdoor sports in cool weather.",
                            Name = "NIKE LS STRIKER IV JSY (SP16)",
                            Price = 22.15m,
                            VendorCode = "725885-739"
                        },
                        new
                        {
                            GoodId = 3,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = true,
                            LongDescription = "This model sits comfortably on the body during training, does not interfere with freedom of movement and provides convenience for the athlete's body. Good ventilation qualities of the jersey provide the necessary amount of fresh air for the body of a football player. In the production of the material, modern Dri-FIT technology is used, which absorbs moisture from the surface of the body, transfers it to the outer layer, where it evaporates, which ensures comfortable dry conditions.",
                            Name = "NIKE SS STIKER IV JSY",
                            Price = 20.25m,
                            VendorCode = "725892-739"
                        },
                        new
                        {
                            GoodId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg",
                            InStock = false,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Dri-FIT technology helps remove moisture and provides comfort. A collar with a V-neck and piping does not rub the skin. Mesh inserts on the back provide extra ventilation. Raglan cut sleeves without a shoulder seam do not constrain movements. Swoosh logo is embroidered on the right chest.",
                            Name = "Nike Striped Division III SS",
                            Price = 35.99m,
                            VendorCode = "894081-739"
                        },
                        new
                        {
                            GoodId = 5,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Football boots NIKE MERCURIAL VAPOR XI CR7 AG-PRO 878647-001 SR professional model for synthetic grass fields. The boots are part of the CR7 Chapter 4: Forged For Greatness name collection, created with the participation of world football star Cristiano Ronaldo and dedicated to his brilliant career. Boots received updated colors. The sole and the edge of the upper in contact with it have a gradient, orange color, which turns into a metallic, gray color of the upper. The coloring evokes associations with the molten metal from which the mold is created.",
                            Name = "NIKE MERCURIAL VAPOR XI CR7 AG-PRO",
                            Price = 72.16m,
                            VendorCode = "878647-001 SR"
                        },
                        new
                        {
                            GoodId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Professional-grade model for synthetic grass fields. The boots are part of the Just Do It Pack collection, created specifically for the 2018 FIFA World Cup. The back of the boot is decorated with a triangle made of thirty-two lines. Just so many teams will take part in the 2018 World Cup. The boots have a great fit, comfort, flexibility, give the player a great ball feel thanks to their all-cut top, which is made of Flyknit woven material. A thin layer of NikeSkin polyurethane mesh, which covers the surface of the boot, gives added density and precision to the fit.",
                            Name = "NIKE VAPOR XII ELITE AG-PRO",
                            Price = 135.99m,
                            VendorCode = "AH7379-107 SR"
                        },
                        new
                        {
                            GoodId = 7,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "A semi-professional model from the Just Do It Pack collection, which was created specifically for the 2018 World Cup. Cleats are designed for dry, natural, grassy lawns. The hybrid top combines kangaroo leather in its design, which during processing maintains its natural structure and elasticity, and Flyknit synthetic material, which is used in the back of the top and for the inner tongue. This ensures an ideal, tight and comfortable fit, excellent breathability and lightweight boots.",
                            Name = "NIKE LEGEND VII PRO FG",
                            Price = 120.95m,
                            VendorCode = "AH7241-107 SR"
                        },
                        new
                        {
                            GoodId = 8,
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "The bag has one large central compartment in which you can conveniently transport sportswear and accessories. The bag is sewn of dense fabric, polyester, which has a woven structure, which provides high wear resistance, the fabric is resistant to mechanical stress, it does not tear and does not deform. The material is water-repellent, which protects the contents from getting wet during transport. The model has a size, the bottom is 16.1 (41 cm) x 9 (23 cm), the height of the bag is 9 (23 cm).",
                            Name = "NIKE BAG BA51",
                            Price = 22.37m,
                            VendorCode = "BA5185 - 010"
                        },
                        new
                        {
                            GoodId = 9,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Match Pennant for game Kairat-AZ ALKMAAR",
                            Name = "Pennant Kairat - Alkmar",
                            Price = 120.5m,
                            VendorCode = "13121010"
                        },
                        new
                        {
                            GoodId = 10,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Gift badge in metal box",
                            Name = "FC Kairat gift badge",
                            Price = 12.95m,
                            VendorCode = "03112017"
                        },
                        new
                        {
                            GoodId = 11,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg",
                            ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg",
                            InStock = true,
                            IsGoodOfTheWeek = false,
                            LongDescription = "Suitcase tee on a suction cup with the club logo",
                            Name = "Souvenir T-shirt",
                            Price = 9.95m,
                            VendorCode = "1539"
                        });
                });

            modelBuilder.Entity("WebApplication5.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApplication5.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("GoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebApplication5.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("GoodId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("GoodId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication5.Models.Good", b =>
                {
                    b.HasOne("WebApplication5.Models.Category", "Category")
                        .WithMany("Goods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication5.Models.OrderDetail", b =>
                {
                    b.HasOne("WebApplication5.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication5.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("WebApplication5.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId");
                });
#pragma warning restore 612, 618
        }
    }
}