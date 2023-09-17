using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> ReadAllAsync();

        Task<Category?> FindByIdAsync(int id);

    }
}
