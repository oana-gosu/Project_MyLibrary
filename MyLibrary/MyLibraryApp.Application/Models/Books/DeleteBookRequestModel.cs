using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Books
{
    public class DeleteBookRequestModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public int? CategoryId { get; set; }
        public int? PublishingHouseId { get; set; }
        public int? PublishingYear { get; set; }
        public byte[]? Picture { get; set; }

        [Required]
        public int Stock { get; set; }

        public Book ToBook()
        {
            return new Book
            {
                Id= this.Id,
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
