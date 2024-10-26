namespace ProductCategoryApp.Services
{
    using ProductCategoryApp.Models;
    using System.Collections.Generic;

    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }

}
