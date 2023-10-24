using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Users;
using MyLibraryApp.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.API.Controllers


{
    [ApiController]
    [Route("Users")]
    
    public class UsersController: ControllerBase


    {

        
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var response = await userService.ReadAllUsersAsync();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersByIdAsync(int id)
        {
            var response = await userService.GetUserByIdAsync(id);

            return Ok(response);
        }
        

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(CreateUserRequestModel requestModel)
        {
            var response = await userService.CreateUserAsync(requestModel);

            return Ok(response);
        }
        [HttpPut]
        public async Task UpdateUserAsync(UpdateUserRequestModel requestModel)
        {
            await userService.UpdateUserAsync(requestModel);
        }

       
    }
}
