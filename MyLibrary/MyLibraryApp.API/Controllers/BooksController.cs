using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.API.Controllers
{
    [ApiController]
    [Route("Books")]
    public class BooksController :ControllerBase
    {
        private readonly IBookService bookService;
        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var response = await bookService.ReadAllBooksAsync();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookByIdAsync(int id)
        {
            var response = await bookService.GetBookByIdAsync(id);

            return Ok(response);
        }
        
        [HttpGet("Author/{author}")]
        public async Task<IActionResult> GetBookByAuthorAsync(string author)
        {
            var response = await bookService.GetAllBooksByAuthor(author);

            return Ok(response);
        }

        [HttpGet("Title/{title}")]
        public async Task<IActionResult> GetBookByTitleAsync(string title)
        {
            var response = await bookService.GetAllBooksByTitle(title);

            return Ok(response);
        }

        [HttpGet("Category/{categoryId}")]
        public async Task<IActionResult> GetBookByCategoryIdAsync(int categoryId)
        {
            var response = await bookService.GetAllByCategoryId(categoryId);

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateBookAsync(CreateBookRequestModel requestModel)
        {
            var response = await bookService.CreateBookAsync(requestModel);

            return Ok(response);
        }

        [HttpPut]
        public async Task UpdateBookAsync(UpdateBookRequestModel requestModel)
        {
            await bookService.UpdateBookAsync(requestModel);
        }

        [HttpDelete]
        public async Task DeleteBookAsync(DeleteBookRequestModel requestModel)
        {
            await bookService.DeleteBookAsync(requestModel);
        }
    }
}
