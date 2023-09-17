using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Services.Interfaces;
using MyLibraryApp.DataAccess.Entities;
using MyLibraryApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;
        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }

        public async Task<BookResponseModel> CreateBookAsync(CreateBookRequestModel requestModel)
        {
            var book = requestModel.ToBook();
            await repository.AddAsync(book);
            return BookResponseModel.FromBook(book);
        }
        public async Task UpdateBookAsync(UpdateBookRequestModel requestModel)
        {
            var book = requestModel.ToBook();
            await repository.UpdateAsync(book);
        }
        public async Task DeleteBookAsync(DeleteBookRequestModel requestModel)
        {
            var book = requestModel.ToBook();
            await repository.DeleteAsync(book);
        }

        public async Task<BookResponseModel> GetBookByIdAsync(int id)
        {
            var book = await repository.GetAsync(id);
            return BookResponseModel.FromBook(book);
        }
        public async Task<List<BookResponseModel>> GetAllBooksByTitle(string title)
        {
            var books = await repository.GetAllByTitle(title);
            return books.Select(BookResponseModel.FromBook).ToList();
        }
        public async Task<List<BookResponseModel>> GetAllBooksByAuthor(string author)
        {
            var books = await repository.GetAllByAuthor(author);
            return books.Select(BookResponseModel.FromBook).ToList();
        }
        public async Task<List<BookResponseModel>> GetAllBooksByCategory(int category)
        {
            var books = await repository.GetAllByCategory(category);
            return books.Select(BookResponseModel.FromBook).ToList();
        }
        public async Task<List<BookResponseModel>> ReadAllBooksAsync()
        {
            var books = await repository.ReadAllAsync();
            return books.Select(BookResponseModel.FromBook).ToList();
        }
    }
}
