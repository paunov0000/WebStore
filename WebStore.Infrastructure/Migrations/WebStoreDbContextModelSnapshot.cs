﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Infrastructure.Data;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    [DbContext(typeof(WebStoreDbContext))]
    partial class WebStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Date of creating the ApplicationUser");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("First name of the ApplicationUser");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Last name of the ApplicationUser");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", null, t =>
                        {
                            t.HasComment("Holds info for the Application User entity");
                        });
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key of the customer");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Address of the Customer entity");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("City of the Customer entity");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("State of the Customer entity");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key to the ApplicationUser entity");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Zip of the Customer entity");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers", t =>
                        {
                            t.HasComment("Holds info for the Customer entity");
                        });
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Primary key of the order");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key of the Customer");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date of the order");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders", t =>
                        {
                            t.HasComment("Holds info for the Order entity");
                        });
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key of the product");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Date of the product creation");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Description of the product");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Image URL of the product");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("A flag which sets the product state as whether its visible or not");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Manufacturer of the product");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Name of the product");

                    b.Property<bool>("OnSale")
                        .HasColumnType("bit")
                        .HasComment("A flag which sets the product state whether its on sale or not");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Price of the product");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key of the product category");

                    b.Property<int>("SoldCount")
                        .HasColumnType("int")
                        .HasComment("Quantity of products sold");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products", t =>
                        {
                            t.HasComment("Holds info for the Product entity");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7612),
                            Description = "Iconic blend of rose and jasmine, a classic from luxury brand Chanel",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Chanel",
                            Name = "Chanel No. 5",
                            OnSale = false,
                            Price = 120.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6c"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7621),
                            Description = "Youthful and fresh floral scent with notes of jasmine and violet",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Marc Jacobs",
                            Name = "Marc Jacobs Daisy",
                            OnSale = false,
                            Price = 80.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6c"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7624),
                            Description = "Modern and vibrant floral bouquet featuring tuberose and jasmine",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Gucci",
                            Name = "Gucci Bloom",
                            OnSale = false,
                            Price = 150.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6c"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7627),
                            Description = "Intensely floral with notes of jasmine, rose, and orchid",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Viktor&Rolf",
                            Name = "Viktor&Rolf Flowerbomb",
                            OnSale = false,
                            Price = 110.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6c"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7629),
                            Description = "Timeless oriental scent with vanilla, iris, and amber notes",
                            ImageUrl = "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg",
                            IsDeleted = false,
                            Manufacturer = "Guerlain",
                            Name = "Shalimar by Guerlain",
                            OnSale = false,
                            Price = 140.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6d"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7634),
                            Description = "Rich and spicy oriental fragrance with exotic undertones",
                            ImageUrl = "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85",
                            IsDeleted = false,
                            Manufacturer = "Yves Saint Laurent",
                            Name = "Opium by Yves Saint Laurent",
                            OnSale = false,
                            Price = 100.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6e"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7637),
                            Description = "Luxurious blend of black truffle, vanilla, and orchid",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Tom Ford",
                            Name = "Black Orchid by Tom Ford",
                            OnSale = false,
                            Price = 180.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6e"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7639),
                            Description = "Fresh and aquatic scent with notes of citrus and rosemary",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Giorgio Armani",
                            Name = "Acqua di Gio by Giorgio Armani",
                            OnSale = false,
                            Price = 85.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6e"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7641),
                            Description = "Citrusy and woody fragrance with notes of grapefruit and cedar",
                            ImageUrl = "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612",
                            IsDeleted = false,
                            Manufacturer = "Hermès",
                            Name = "Terre d'Hermès by Hermès",
                            OnSale = false,
                            Price = 120.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6f"),
                            SoldCount = 0
                        },
                        new
                        {
                            Id = new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                            CreatedOn = new DateTime(2024, 2, 26, 19, 17, 26, 801, DateTimeKind.Utc).AddTicks(7645),
                            Description = "Fresh and fruity scent with notes of pineapple and blackcurrant",
                            ImageUrl = "https://creedboutique.com/cdn/shop/files/aventus-100ml-bottle_3413e5f4-3eee-40b3-8451-2546a370ec5b.jpg?v=1700498936&width=1500",
                            IsDeleted = false,
                            Manufacturer = "Creed",
                            Name = "Aventus by Creed",
                            OnSale = false,
                            Price = 250.00m,
                            ProductCategoryId = new Guid("53146915-6199-44eb-aedb-e9902299be6f"),
                            SoldCount = 0
                        });
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key of the product category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Description of the product category");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Name of the product category");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories", t =>
                        {
                            t.HasComment("Holds info for the Product Category entity");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("53146915-6199-44eb-aedb-e9902299be6c"),
                            Description = "Floral scents are the most popular and widely used perfume family. Floral perfumes are feminine, romantic, and ultra-feminine.",
                            Name = "Floral"
                        },
                        new
                        {
                            Id = new Guid("53146915-6199-44eb-aedb-e9902299be6d"),
                            Description = "Oriental perfumes are warm, sensual, and exotic. They are often described as spicy, sweet, and even opulent.",
                            Name = "Oriental"
                        },
                        new
                        {
                            Id = new Guid("53146915-6199-44eb-aedb-e9902299be6e"),
                            Description = "Fresh perfumes are often referred to as citrus or green. They are light, airy, and clean.",
                            Name = "Fresh"
                        },
                        new
                        {
                            Id = new Guid("53146915-6199-44eb-aedb-e9902299be6f"),
                            Description = "Woody perfumes are warm, earthy, and sensual. They are often described as musky, aromatic, and spicy.",
                            Name = "Woody"
                        });
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key of the review");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Comment of the review");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasComment("Date of the review");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key of the Customer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign key of the product");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasComment("Rating for the reviewed product");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Title of the review");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasComment("Date of updating the review");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews", t =>
                        {
                            t.HasComment("Holds info for the Review entity");
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Infrastructure.Data.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Customer", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Order", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Infrastructure.Data.Entities.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Product", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Review", b =>
                {
                    b.HasOne("WebStore.Infrastructure.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Infrastructure.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebStore.Infrastructure.Data.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
