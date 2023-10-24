using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Orders;
using MyLibraryApp.Application.Services;
using MyLibraryApp.Application.Services.Interfaces;

namespace MyLibraryApp.API.Controllers
{
    [ApiController]
    [Route("Orders")]


    public class OrdersController: ControllerBase
    {
        private readonly IOrderService orderService;
        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            var response = await orderService.ReadAllOrdersAsync();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderByIdAsync(int id)
        {
            var response = await orderService.GetOrderByIdAsync(id);

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync(CreateOrderRequestModel requestModel)
        {
            var response = await orderService.CreateOrderAsync(requestModel);

            return Ok(response);
        }

        [HttpPut]
        public async Task UpdateOrderAsync(UpdateOrderRequestModel requestModel)
        {
            await orderService.UpdateOrderAsync(requestModel);
        }

    }
}
