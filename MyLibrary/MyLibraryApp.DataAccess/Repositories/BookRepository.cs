using Microsoft.EntityFrameworkCore;
using MyLibraryApp.DataAccess.Entities;
using MyLibraryApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DatabaseContext databaseContext;
        public BookRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public async Task<Book> AddAsync(Book book)
        {
            var addedEntity = await databaseContext.Books.AddAsync(book);

            await databaseContext.SaveChangesAsync();

            return addedEntity.Entity;
        }

        public async Task DeleteAsync(Book book)
        {
            databaseContext.Remove(book);

            await databaseContext.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAllByAuthor(string author)
        {
            return await databaseContext.Books.Where(b => b.Author.ToUpper().Contains(author.ToUpper())).ToListAsync();
        }

        public async Task<List<Book>> GetAllByCategoryId(int categoryId)
        {
            return await databaseContext.Books.Where(b => b.CategoryId == categoryId).ToListAsync();
        }

        public async Task<List<Book>> GetAllByTitle(string title)
        {
            return await databaseContext.Books.Where(b => b.Title.ToUpper().Contains(title.ToUpper()) ||
             b.Author.ToUpper().Contains(title.ToUpper())).ToListAsync();
        }

        public async Task<Book> GetAsync(int id)
        {
            return await databaseContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Book>> ReadAllAsync()
        {
            return await databaseContext.Books.ToListAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            databaseContext.Update(book);
            await databaseContext.SaveChangesAsync();

        }
    }
}
