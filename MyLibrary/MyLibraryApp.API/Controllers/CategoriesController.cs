using Microsoft.AspNetCore.Mvc;
using MyLibraryApp.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.API.Controllers
{
    [ApiController]
    [Route("categories")]

    public class CategoriesController :ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await categoryService.ReadAllCAtegoriesAsync();

            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var response =await categoryService.FindCategoryByIdAsync(id);
            return Ok(response);
        }
    }
}
