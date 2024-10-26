namespace ProductCategoryApp.Services
{
    using Microsoft.EntityFrameworkCore;
    using ProductCategoryApp.Models;
    using ProductCategoryApp.Reposirtoty;
    using System.Collections.Generic;
    using System.Linq;
   

    public class CategoryService : ICategoryService
    {
        private readonly ProductCategoryContext _context;

        public CategoryService(ProductCategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }

}
