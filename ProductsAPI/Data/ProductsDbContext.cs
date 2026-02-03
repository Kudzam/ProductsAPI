using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class ProductsDbContext(DbContextOptions<ProductsDbContext> options): DbContext(options)
    {
        //adding a database set resulting in the creation of our table
        public DbSet<ProductsModel> ProductsModels { get; set; }
    }
}
