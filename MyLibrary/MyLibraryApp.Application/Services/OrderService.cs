using MyLibraryApp.Application.Models.Orders;
using MyLibraryApp.Application.Services.Interfaces;
using MyLibraryApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository repository;
        public OrderService(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public async Task<OrderResponseModel> CreateOrderAsync(CreateOrderRequestModel requestModel)
        {
            var order = requestModel.ToOrder();
            await repository.AddAsync(order);
            return OrderResponseModel.FromOrder(order);
        }

        public async Task UpdateOrderAsync(UpdateOrderRequestModel requestModel)
        {
            var order = requestModel.ToOrder();
            await repository.UpdateAsync(order);
        }
        

        public async Task<OrderResponseModel> GetOrderByIdAsync(int id)
        {
            var order = await repository.GetAsync(id);
            return OrderResponseModel.FromOrder(order);
        }
                
       public async Task<List<OrderResponseModel>> ReadAllOrdersAsync()
        {
            var orders = await repository.ReadAllAsync();
            return orders.Select(OrderResponseModel.FromOrder).ToList();
        }
    }
}

