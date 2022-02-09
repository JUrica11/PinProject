using System.Collections.Generic;
using System.Data.Entity;

namespace PinProject.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Auto B"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Kamion C"
                },
                
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Ljetna Auto Guma",
                    Description = "Continental - Continental uzima u obzir svaki pojedini sigurnosni aspekt i aspekt učinkovitosti",
                    ImagePath ="continental.jpg",
                    UnitPrice = 100,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Zimska Auto Guma",
                    Description = "Sava Eskimo-U potrazi ste za Sava gumama? Povoljno, brzo i jednostavno.",
                    ImagePath="sava.jfif",
                    UnitPrice = 70.35,
                    CategoryID = 1
               },
             
                new Product
                {
                    ProductID = 3,
                    ProductName = "Ljetna Kamionska Guma",
                    Description = "ToyoTires - Nudi visoke razine sigurnosti, izdržljivosti, ekonomičnosti i komfora.",
                    ImagePath="toyo.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Zimska Kamionska Guma",
                    Description = "Pirelli - Guma Pirelli se često povezuje uz luksuz i sportski duh.",
                    ImagePath="pirelli.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
         
            };

            return products;
        }
    }
}