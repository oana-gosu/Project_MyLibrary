using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Orders;

namespace MyLibraryApp.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderResponseModel> CreateOrderAsync(CreateOrderRequestModel requestModel);

        Task UpdateOrderAsync(UpdateOrderRequestModel requestModel);

        Task<OrderResponseModel> GetOrderByIdAsync(int id);

        Task<List<OrderResponseModel>> ReadAllOrdersAsync();
    }
}
