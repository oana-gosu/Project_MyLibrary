using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Books
{
    public class UpdateBookRequestModel
    {
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public int? CategoryId { get; set; }
        public int? PublishingHouseId { get; set; }
        public int? PublishingYear { get; set; }
        public string Picture { get; set; }

        [Required]
        public int Stock { get; set; }

        public Book ToBook()
        {
            return new Book
            {
                Title = this.Title,
                Author = this.Author,
                Details = this.Details,
                CategoryId = this.CategoryId,
                PublishingYear = this.PublishingYear,
                PublishingHouseId = this.PublishingHouseId,
                Picture = this.Picture,
                Stock = this.Stock
            };
        }
    }
}
