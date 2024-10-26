using Microsoft.EntityFrameworkCore;
using ProductCategoryApp.Models;
using System.Collections.Generic;

namespace ProductCategoryApp.Reposirtoty
{
    public class ProductCategoryContext : DbContext
    {
        public ProductCategoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
