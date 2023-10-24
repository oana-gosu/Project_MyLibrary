using MyLibraryApp.Application.Models.Orders;
using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Orders
{
    public class OrderResponseModel
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Details { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public int StatusId { get; set; }

        public static OrderResponseModel FromOrder(Order order)
        {
            return new OrderResponseModel
            {
                Id = order.Id,
                StartDate = order.StartDate,
                ReturnDate = order.ReturnDate,
                Details = order.Details,
                BookId = order.BookId,
                UserId = order.UserId,
                StatusId = order.StatusId,
                
            };
        }
    }
}
