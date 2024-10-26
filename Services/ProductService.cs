namespace ProductCategoryApp.Services
{
    using Microsoft.EntityFrameworkCore;
    using ProductCategoryApp.Models;
    using ProductCategoryApp.Reposirtoty;
    using System.Collections.Generic;
    using System.Linq;
   
    public class ProductService : IProductService
    {
        private readonly ProductCategoryContext _context;

        public ProductService(ProductCategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetPagedProducts(int page, int pageSize)
        {
            return _context.Products
                           .Include("Category")
                           .OrderBy(p => p.ProductId)
                           .Skip((page - 1) * pageSize)
                           .Take(pageSize)
                           .ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Category").FirstOrDefault(p => p.ProductId == id);
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public int GetTotalProductCount()
        {
            return _context.Products.Count();
        }
    }

}
