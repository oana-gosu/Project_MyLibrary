using Microsoft.EntityFrameworkCore;
using MyLibraryApp.DataAccess.Entities;
using MyLibraryApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public async Task<Category> AddAsync(Category category)
        {
            var addedEntity = await databaseContext.Categories.AddAsync(category);

            await databaseContext.SaveChangesAsync();

            return addedEntity.Entity;
        }
        public async Task<Category?> FindByIdAsync(int id)
        {
            return await databaseContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Category>> ReadAllAsync()
        {
            return await databaseContext.Categories.ToListAsync();
        }
    }
}
