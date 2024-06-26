﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Category;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Brand;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Subcategory;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.IsActive)
                .HasDefaultValue(true);

            builder
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder
                .Property(p => p.OriginalPrice)
                .HasPrecision(18, 2);

            builder.HasData(CreateProducts());
        }

        public List<Product> CreateProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id = Guid.Parse(Chanel05Id),
                    Name = "No. 5",
                    Description = "Iconic blend of rose and jasmine, a classic from luxury brand Chanel",
                    Price = 120.34M,
                    OriginalPrice = 120.34M,
                    ImageUrl ="https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(ChanelId),
                    Quantity = 9,
                    SoldCount = 37,
                    OnSale = false,
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(MarcJacobsDaisyId),
                    Name = "Daisy",
                    Description = "Youthful and fresh floral scent with notes of jasmine and violet",
                    Price = 80.00M,
                    OriginalPrice = 120.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(MarcJacobsId),
                    Quantity = 12,
                    SoldCount = 51,
                    OnSale = true,
                    IsActive = true,
                    ChildSubcategoryId = Guid.Parse("3716553d-4f92-4e15-a411-0ff574e459cc")
                },
                new Product
                {
                    Id = Guid.Parse(GucciBloomId),
                    Name = "Bloom",
                    Description = "Modern and vibrant floral bouquet featuring tuberose and jasmine",
                    Price = 149.99M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(GucciId),
                    Quantity = 193,
                    SoldCount = 12,
                    OriginalPrice = 179.99M,
                    OnSale = true,
                    IsActive= true,
                    TopNotes="Jasmine",
                    MiddleNotes="Tuberose",
                    BaseNotes="Orris Root, Honeysuckle",
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(ViktorRolfFlowerbombId),
                    Name = "Flowerbomb",
                    Description = "Intensely floral with notes of jasmine, rose, and orchid",
                    Price = 110.82M,
                    OriginalPrice = 110.82M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(ViktorRolfId),
                    Quantity = 23,
                    SoldCount = 84,
                    OnSale = false,
                    IsActive = true,
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(ShalimarByGuerlainId),
                    Name = "Shalimar",
                    Description = "Timeless oriental scent with vanilla, iris, and amber notes",
                    Price = 142.61M,
                    ImageUrl = "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(GuerlainId),
                    Quantity = 0,
                    SoldCount = 93,
                    OriginalPrice = 251.49M,
                    OnSale = true,
                    IsActive= true,
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(OpiumByYvesSaintLaurentId),
                    Name = "Opium",
                    Description = "Rich and spicy oriental fragrance with exotic undertones",
                    Price = 101.00M,
                    OriginalPrice = 101.00M,
                    ImageUrl = "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(YvesSaintLaurentId),
                    Quantity = 4,
                    SoldCount = 34,
                    OnSale = false,
                    IsActive= false,
                    TopNotes="Mandarin Orange, Bergamot, Lily-of-the-Valley",
                    MiddleNotes="Myrhh, Jasmine",
                    BaseNotes="Opoponax, Amber, Patchouli, Vanille",
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(BlackOrchidByTomFordId),
                    Name = "Black Orchid",
                    Description = "Luxurious blend of black truffle, vanilla, and orchid",
                    Price = 180.00M,
                    OriginalPrice = 180.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(WomenSubcategoryId),
                    BrandId = Guid.Parse(TomFordId),
                    Quantity = 17,
                    SoldCount = 133,
                    OnSale = false,
                    IsActive = true,
                    TopNotes = "Truffle, Gardenia, Black Currant, Ylang-Ylang, Jasmine, Bergamot, Mandarin Orange, Amalfi Lemon",
                    MiddleNotes="Orchid, Spices, Gardenia, Fruity Notes, Ylang-Ylang, Jasmine, Lostus",
                    BaseNotes ="Mexican Chocolate, Patchouli, Vanille, Incense, Amber, Sandalwood, Vetiver, White Musk",
                    ChildSubcategoryId=Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(AcquaDiGioByGiorgioArmaniId),
                    Name = "Acqua di Gio",
                    Description = "Fresh and aquatic scent with notes of citrus and rosemary",
                    Price = 85.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(MenSubcategoryId),
                    BrandId = Guid.Parse(ArmaniId),
                    Quantity = 95,
                    SoldCount = 32,
                    OriginalPrice = 121.21M,
                    OnSale = true,
                    IsActive = true,
                    ChildSubcategoryId = Guid.Parse("3716553d-4f92-4e15-a411-0ff574e459cc")
                },
                new Product
                {
                    Id = Guid.Parse(TerreDhermesByHermesId),
                    Name = "Terre d'Hermès",
                    Description = "Citrusy and woody fragrance with notes of grapefruit and cedar",
                    Price = 120.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(MenSubcategoryId),
                    BrandId = Guid.Parse(HermesId),
                    Quantity = 52,
                    SoldCount = 3,
                    OriginalPrice = 333.33M,
                    OnSale = true,
                    IsActive = true,
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                },
                new Product
                {
                    Id = Guid.Parse(AventusByCreedId),
                    Name = "Aventus",
                    Description = "Fresh and fruity scent with notes of pineapple and blackcurrant",
                    Price = 249.99M,
                    OriginalPrice = 249.99M,
                    ImageUrl = "https://www.creedfragrances.co.uk/cdn/shop/files/Clear-logo-with-black-hair.jpg?v=1708086869&width=750",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    ParentSubcategoryId = Guid.Parse(UnisexSubcategoryId),
                    BrandId = Guid.Parse(CreedId),
                    Quantity = 0,
                    SoldCount = 86,
                    OnSale = false,
                    IsActive = true,
                    ChildSubcategoryId = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76")
                }
            };
        }
    }
}

