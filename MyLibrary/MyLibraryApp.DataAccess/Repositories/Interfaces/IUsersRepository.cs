using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<User> AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);

        Task<User> GetAsync(int id);
        Task<List<User>> GetAllByName(string lastName);
        Task<List<User>> ReadAllAsync();
    }
}
