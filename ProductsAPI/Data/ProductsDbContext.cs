using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class ProductsDbContext(DbContextOptions<ProductsDbContext> options): DbContext(options)
    {
        //adding a database set resulting in the creation of our table
        public DbSet<ProductsModel> ProductsModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductsModel>().HasData(
                new ProductsModel
                {
                    Id = 1,
                    ProductType = "Jeans",
                    ProductLabel = "Levi",
                    Contractor = "Outsource",
                    Quantity = 90
                },
            new ProductsModel
            {
                Id = 2,
                ProductType = "T-Shirt",
                ProductLabel = "Next",
                Contractor = "Outsource",
                Quantity = 38
            },
            new ProductsModel
            {
                Id = 3,
                ProductType = "Jacket",
                ProductLabel = "RiverIsland",
                Contractor = "InHouse",
                Quantity = 50
            });
        }
    }
}
