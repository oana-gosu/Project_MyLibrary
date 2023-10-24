using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryResponseModel> CreateCategoryAsync(CreateCategoryRequestModel requestModel);
        Task<List<CategoryResponseModel>> ReadAllCAtegoriesAsync();
        Task<CategoryResponseModel> FindCategoryByIdAsync(int Id);
    }
}
