using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Milestone2.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category{
                    CategoryID = 1,
                    CategoryName = "CARs" },
                new Category{
                    CategoryID = 2,
                    CategoryName = "SUVs" },
                new Category{
                    CategoryID = 3,
                    CategoryName = "PICKUP TRUCKs" },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>{
                new Product{
                    ProductID = 1,
                    ProductName = "Mercedes-Benz GLE",
                    Description = "The redesigned 2020 Mercedes-Benz GLE provides cutting-edge technology, balanced performance, and an authentically luxurious experience for travelers. As a result, it's one of our top-ranking luxury midsize Car.",
                    ImagePath = "Image/IMG_0016.jpg",
                    UnitPrice = 16000.00,
                    CategoryID = 1 },

                new Product{
                    ProductID = 2,
                    ProductName = "BMW M4",
                    Description = "The 2020 BMW M4 is a great pick if you’re looking for a luxury car. The M4 has a spacious five-seat interior, a sizable cargo area, and one of the best infotainment systems in the luxury car.",
                    ImagePath = "Image/IMG_0011.jpg",
                    UnitPrice = 18000.00,
                    CategoryID = 1 },

                new Product{
                    ProductID = 3,
                    ProductName = "Jeep Wranbler",
                    Description = "The 2020 Jeep Wrangler boasts terrific off-road performance and easy-to-use tech features, but it ranks toward the back of the compact SUV class because of its poor predicted reliability rating.",
                    ImagePath = "Image/IMG_0013.jpg",
                    UnitPrice = 22000.00,
                    CategoryID = 2 },

                new Product{
                    ProductID = 4,
                    ProductName = "Honda Civic",
                    Description = "The 2020 Honda Civic is a great vehicle.It offers more versatility than many compact cars. Regardless of which body style you choose, you’ll get an agile, spirited car with good fuel economy estimates and an upscale cabin.",
                    ImagePath = "Image/IMG_0010.jpg",
                    UnitPrice = 10000.00,
                    CategoryID = 1 },

                new Product{
                    ProductID = 5,
                    ProductName = "Toyota Mark X",
                    Description = "The 2018 Toyota Mark X is perfect for those who covet Lexus quality combined with reliability, but perhaps cannot quite afford it. Available as a sedan, coupe, or hatchback, it offers more versatility than many compact cars.",
                    ImagePath = "Image/IMG_0014.jpg",
                    UnitPrice = 8000.00,
                    CategoryID = 1 },

                new Product{
                    ProductID = 6,
                    ProductName = "Ford Ranger",
                    Description = " The 2019 Ford Ranger holds its own in our compact pickup truck rankings. It has about everything you could want from a truck, including a powerful engine, respectable towing and hauling abilities, and plenty of available features.",
                    ImagePath = "Image/IMG_0015.jpg",
                    UnitPrice = 18000.00,
                    CategoryID = 3 },
            };
            return products;
        }
    }
}