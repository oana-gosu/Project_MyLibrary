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
    public  class OrderRepository: IOrderRepository
    {
        private readonly DatabaseContext databaseContext;
        public OrderRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public async Task<Order> AddAsync(Order order)
        {
            var addedEntity = await databaseContext.Orders.AddAsync(order);

            await databaseContext.SaveChangesAsync();

            return addedEntity.Entity;
        }

        public async Task UpdateAsync(Order order)
        {
            databaseContext.Update(order);
            await databaseContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(Order order)
        {
            databaseContext.Remove(order);

            await databaseContext.SaveChangesAsync();
        }

        public async Task<Order> GetAsync(int id)
        {
            return await databaseContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<List<Order>> ReadAllAsync()
        {
            return await databaseContext.Orders.ToListAsync();
        }

    }
}
