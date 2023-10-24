using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyLibraryApp.DataAccess.Entities;
using MyLibraryApp.DataAccess.Repositories.Interfaces;

namespace MyLibraryApp.DataAccess.Repositories
{
    public class UserRepository: IUsersRepository
    {
        private readonly DatabaseContext databaseContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public async Task<User> AddAsync(User user)
        {
            var addedEntity = await databaseContext.Users.AddAsync(user);

            await databaseContext.SaveChangesAsync();

            return addedEntity.Entity;
        }

        public async Task DeleteAsync(User user)
        {
            databaseContext.Remove(user);

            await databaseContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            databaseContext.Update(user);
            await databaseContext.SaveChangesAsync();

        }

        public async Task<User> GetAsync(int id)
        {
            return await databaseContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetAllByName(string lastName)
        {
            return await databaseContext.Users.Where(u => u.LastName.Contains(lastName)).ToListAsync();
        }
        public async Task<List<User>> ReadAllAsync()
        {
            return await databaseContext.Users.ToListAsync();
        }


    }
}
