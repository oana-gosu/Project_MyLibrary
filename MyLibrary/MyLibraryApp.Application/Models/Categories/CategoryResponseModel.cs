using MyLibraryApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Categories
{
    public class CategoryResponseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Details { get; set; }
        public static CategoryResponseModel FromCategory(Category category)
        {
            return new CategoryResponseModel
            {
                Id = category.Id,
                Name = category.Name,
                Details = category.Details
            };
        }
    }
}
