using MyLibraryApp.Application.Models.Books;
using MyLibraryApp.Application.Models.Categories;
using MyLibraryApp.Application.Services.Interfaces;
using MyLibraryApp.DataAccess.Repositories.Interfaces;

namespace MyLibraryApp.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;

        public async Task<CategoryResponseModel> CreateCategoryAsync(CreateCategoryRequestModel requestModel)
        {
            var category = requestModel.ToCategory();
            await repository.AddAsync(category);
            return CategoryResponseModel.FromCategory(category);
        }
        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<CategoryResponseModel> FindCategoryByIdAsync(int Id)
        {
            var category = await repository.FindByIdAsync(Id);
            return CategoryResponseModel.FromCategory(category);
        }

        public async Task<List<CategoryResponseModel>> ReadAllCAtegoriesAsync()
        {
            var categories = await repository.ReadAllAsync();

            return categories.Select(CategoryResponseModel.FromCategory).ToList();
        }
    }
}
