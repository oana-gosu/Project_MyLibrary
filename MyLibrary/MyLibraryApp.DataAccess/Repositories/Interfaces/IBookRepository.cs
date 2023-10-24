using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);

        Task<Book> GetAsync(int id);
        Task<List<Book>> GetAllByTitle(string title);
        Task<List<Book>> GetAllByAuthor(string author);
        Task<List<Book>> GetAllByCategoryId(int categoryId);
        Task<List<Book>> ReadAllAsync();
    }
}
