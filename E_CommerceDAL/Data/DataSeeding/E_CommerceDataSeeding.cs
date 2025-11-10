using E_CommerceDAL.Data.Contexts;
using E_CommerceDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDAL.Data.DataSeeding
{
    public class E_CommerceDataSeeding
    {
        public static bool SeedData(E_CommerceDbContext dbContext)
        {
            try
            {
                bool hasCategories = dbContext.Categories.Any();
                bool hasProducts = dbContext.Products.Any();

                if (hasCategories || hasProducts) return false;

                if (!hasCategories)
                {
                    var Categories = new List<Category>()
                    {
                        new Category
                        {
                            Name = "C1",
                            Description = "C1"
                        },

                          new Category
                        {
                            Name = "C2",
                            Description = "C2"
                        },

                          new Category
                        {
                            Name = "C3",
                            Description = "C3"
                        },
                    };

                    dbContext.Categories.AddRange(Categories);
                }

                if (!hasProducts)
                {
                    var Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "P1",
                            Description = "P1",
                            Price = 150,
                            ProductColor = ProductColor.Red,
                            CategoryId = 1,
                            Image = "https..."  
                        },


                        new Product
                        {
                            Name = "P2",
                            Description = "P2",
                            Price = 200,
                            ProductColor = ProductColor.Red,
                            CategoryId = 2,
                            Image = "https..."
                        },

                         new Product
                        {
                            Name = "P3",
                            Description = "P3",
                            Price = 350,
                            ProductColor = ProductColor.Yellow,
                            CategoryId = 3,
                            Image = "https..."
                        },
                    };

                    dbContext.Products.AddRange(Products);
                }

                int RowAffected = dbContext.SaveChanges();

                return RowAffected > 0; // if RowAffected > 0 return true else return false
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Seeding Failed : {ex}");
                return false;
            }
        }
    }
}
