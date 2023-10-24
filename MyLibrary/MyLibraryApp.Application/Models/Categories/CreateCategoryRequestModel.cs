using MyLibraryApp.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Application.Models.Categories
{
    public class CreateCategoryRequestModel
    {
        [Required] 
        public string Name { get; set;}

        public string Details { get; set;}

        public Category ToCategory()
        {
            return new Category
            {
                Name = this.Name,
                Details = this.Details,
                
            };
        }

    }
}
