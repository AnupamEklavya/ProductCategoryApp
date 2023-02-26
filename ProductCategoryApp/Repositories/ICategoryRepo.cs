using ProductCategoryApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCategoryApp.Repositories
{
    public interface ICategoryRepo
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(Category category);
    }
}
