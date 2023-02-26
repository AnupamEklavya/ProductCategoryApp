using Microsoft.EntityFrameworkCore;
using ProductCategoryApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCategoryApp.Repositories
{
    public class CategoryRepo:ICategoryRepo
    {
        private readonly ProductContext _context;

        public CategoryRepo(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task AddCategory(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(Category category)
        {
            _context.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
