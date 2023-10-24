using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Books
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public int? CategoryId { get; set; }
        public int? PublishingHouseId { get; set; }
        public int? PublishingYear { get; set; }
        public string Picture { get; set; }
        public int Stock { get; set; }

        public static BookResponseModel FromBook(Book book)
        {
            return new BookResponseModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Details = book.Details,
                CategoryId = book.CategoryId,
                PublishingHouseId = book.PublishingHouseId,
                PublishingYear = book.PublishingYear,
                Picture = book.Picture,
                Stock = book.Stock
            };
        }
    }
}
