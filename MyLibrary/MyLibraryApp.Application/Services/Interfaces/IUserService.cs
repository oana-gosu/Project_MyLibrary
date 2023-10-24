using System;
using MyLibraryApp.Application.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryApp.Application.Models.Books;

namespace MyLibraryApp.Application.Services.Interfaces
{
    public  interface IUserService
    {
        Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel);
        Task UpdateUserAsync(UpdateUserRequestModel requestModel);
        
        Task<UserResponseModel> GetUserByIdAsync(int id);
        
        Task<List<UserResponseModel>> ReadAllUsersAsync();
    }
}
