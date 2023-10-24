using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Users;
using MyLibraryApp.Application.Services.Interfaces;
using MyLibraryApp.DataAccess.Entities;
using MyLibraryApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Services
{
    public class UserServices: IUserService
    {
        private readonly IUsersRepository repository;
        public UserServices(IUsersRepository repository)
        {
            this.repository = repository;
        }

        public async Task<UserResponseModel> CreateUserAsync(CreateUserRequestModel requestModel)
        {
            var user = requestModel.ToUser();
            await repository.AddAsync(user);
            return UserResponseModel.FromUser(user);
        }
        public async Task UpdateUserAsync(UpdateUserRequestModel requestModel)
        {
            var user = requestModel.ToUser();
            await repository.UpdateAsync(user);
        }
      
        public async Task<UserResponseModel> GetUserByIdAsync(int id)
        {
            var user = await repository.GetAsync(id);
            return UserResponseModel.FromUser(user);
        }
        
        public async Task<List<UserResponseModel>> ReadAllUsersAsync()
        {
            var user = await repository.ReadAllAsync();
            return user.Select(UserResponseModel.FromUser).ToList();
        }
    }
}
