using ProductCategoryApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCategoryApp.Repositories
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
