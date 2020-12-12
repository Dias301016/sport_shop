using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Kits" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Sport shoes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Paraphernalia" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Sport bags" });

            

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 1,
                Name = " Nike ACADEMY16 SS TOP (SP16)",
                Price = 20.93M,
                VendorCode = "725932 - 739",
                LongDescription =
                    "This model is perfect for sports, it can also be used as a casual sports-style T-shirt or for outdoor recreation. The T-shirt has modern Dri-FIT technology, the essence of the technology is the use of special fibers woven into the fabric, these fibers on the one hand absorb moisture that is released by the body during training, take it out, where evaporation occurs.",
                CategoryId = 1,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg",
                InStock = true,
                IsGoodOfTheWeek = true,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587879.jpeg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 2,
                Name = "NIKE LS STRIKER IV JSY (SP16)",
                Price = 22.15M,
                VendorCode = "725885-739",
                LongDescription =
                   "The yellow Nike Striker IV T - shirt is a great choice for outdoor sports in cool weather.",
                CategoryId = 1,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg",
                InStock = true,
                IsGoodOfTheWeek = true,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587701.jpg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 3,
                Name = "NIKE SS STIKER IV JSY",
                Price = 20.25M,
                VendorCode = "725892-739",
                LongDescription =
                 "This model sits comfortably on the body during training, does not interfere with freedom of movement and provides convenience for the athlete's body. Good ventilation qualities of the jersey provide the necessary amount of fresh air for the body of a football player. In the production of the material, modern Dri-FIT technology is used, which absorbs moisture from the surface of the body, transfers it to the outer layer, where it evaporates, which ensures comfortable dry conditions.",
                CategoryId = 1,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg",
                InStock = true,
                IsGoodOfTheWeek = true,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534587573.jpg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 4,
                Name = "Nike Striped Division III SS",
                Price = 35.99M,
                VendorCode = "894081-739",
                LongDescription = "Dri-FIT technology helps remove moisture and provides comfort. A collar with a V-neck and piping does not rub the skin. Mesh inserts on the back provide extra ventilation. Raglan cut sleeves without a shoulder seam do not constrain movements. Swoosh logo is embroidered on the right chest.",
                CategoryId = 1,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg",
                InStock = false,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1531688067.jpg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 5,
                Name = "NIKE MERCURIAL VAPOR XI CR7 AG-PRO",
                Price = 72.16M,
                VendorCode = "878647-001 SR",
                LongDescription = "Football boots NIKE MERCURIAL VAPOR XI CR7 AG-PRO 878647-001 SR professional model for synthetic grass fields. The boots are part of the CR7 Chapter 4: Forged For Greatness name collection, created with the participation of world football star Cristiano Ronaldo and dedicated to his brilliant career. Boots received updated colors. The sole and the edge of the upper in contact with it have a gradient, orange color, which turns into a metallic, gray color of the upper. The coloring evokes associations with the molten metal from which the mold is created.",
                CategoryId = 2,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533115520.jpg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 6,
                Name = "NIKE VAPOR XII ELITE AG-PRO",
                Price = 135.99M,
                VendorCode = "AH7379-107 SR",
                LongDescription = "Professional-grade model for synthetic grass fields. The boots are part of the Just Do It Pack collection, created specifically for the 2018 FIFA World Cup. The back of the boot is decorated with a triangle made of thirty-two lines. Just so many teams will take part in the 2018 World Cup. The boots have a great fit, comfort, flexibility, give the player a great ball feel thanks to their all-cut top, which is made of Flyknit woven material. A thin layer of NikeSkin polyurethane mesh, which covers the surface of the boot, gives added density and precision to the fit.",
                CategoryId = 2,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113310.jpg"



            });

            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 7,
                Name = "NIKE LEGEND VII PRO FG",
                Price = 120.95M,
                VendorCode = "AH7241-107 SR",
                LongDescription = "A semi-professional model from the Just Do It Pack collection, which was created specifically for the 2018 World Cup. Cleats are designed for dry, natural, grassy lawns. The hybrid top combines kangaroo leather in its design, which during processing maintains its natural structure and elasticity, and Flyknit synthetic material, which is used in the back of the top and for the inner tongue. This ensures an ideal, tight and comfortable fit, excellent breathability and lightweight boots.",
                CategoryId = 2,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533113062.jpg"



            });
            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 8,
                Name = "NIKE BAG BA51",
                Price = 22.37M,
                VendorCode = "BA5185 - 010",
                LongDescription = "The bag has one large central compartment in which you can conveniently transport sportswear and accessories. The bag is sewn of dense fabric, polyester, which has a woven structure, which provides high wear resistance, the fabric is resistant to mechanical stress, it does not tear and does not deform. The material is water-repellent, which protects the contents from getting wet during transport. The model has a size, the bottom is 16.1 (41 cm) x 9 (23 cm), the height of the bag is 9 (23 cm).",
                CategoryId = 4,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1534585907.jpg"



            });
            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 9,
                Name = "Pennant Kairat - Alkmar",
                Price = 120.5M,
                VendorCode = "13121010",
                LongDescription = "Match Pennant for game Kairat-AZ ALKMAAR",
                CategoryId = 3,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533964659.jpg"



            });
            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 10,
                Name = "FC Kairat gift badge",
                Price = 12.95M,
                VendorCode = "03112017",
                LongDescription = "Gift badge in metal box",
                CategoryId = 3,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533724650.jpg"



            });
            modelBuilder.Entity<Good>().HasData(new Good
            {
                GoodId = 11,
                Name = "Souvenir T-shirt",
                Price = 9.95M,
                VendorCode = "1539",
                LongDescription = "Suitcase tee on a suction cup with the club logo",
                CategoryId = 3,
                ImageUrl = "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg",
                InStock = true,
                IsGoodOfTheWeek = false,
                ImageThumbnailUrl = "https://fckairat.com/upload/Products/full/Products-image-1533966706.jpg"



            });


        }
    }
}
