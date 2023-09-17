using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Services.Interfaces
{
    public interface IBookService
    {
        Task<BookResponseModel> CreateBookAsync(CreateBookRequestModel requestModel);
        Task UpdateBookAsync(UpdateBookRequestModel requestModel);
        Task DeleteBookAsync(DeleteBookRequestModel requestModel);

        Task<BookResponseModel> GetBookByIdAsync(int id);
        Task<List<BookResponseModel>> GetAllBooksByTitle(string title);
        Task<List<BookResponseModel>> GetAllBooksByAuthor(string author);
        Task<List<BookResponseModel>> GetAllBooksByCategory(int category);
        Task<List<BookResponseModel>> ReadAllBooksAsync();
    }
}
