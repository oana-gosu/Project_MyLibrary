using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryApp.DataAccess.Entities;

namespace MyLibraryApp.Application.Models.Orders
{
    public class UpdateOrderRequestModel
    {

        [Required]

        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Details { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public int StatusId { get; set; }

        public Order ToOrder()
        {
            return new Order
            {
                Id = this.Id,
                StartDate = this.StartDate,
                ReturnDate = this.ReturnDate,
                Details = this.Details,
                BookId = this.BookId,
                UserId = this.UserId,
                StatusId = this.StatusId,

            };
        }
    }
}
