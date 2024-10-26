namespace ProductCategoryApp.Services
{
    using ProductCategoryApp.Models;
    using System.Collections.Generic;

    public interface IProductService
    {
        IEnumerable<Product> GetPagedProducts(int page, int pageSize);
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        int GetTotalProductCount();
    }

}
