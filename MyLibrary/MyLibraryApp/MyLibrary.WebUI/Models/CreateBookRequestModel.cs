namespace MyLibrary.WebUI.Models;
using System.ComponentModel.DataAnnotations;

    public class CreateBookRequestModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Picture { get; set; }
    
        [Required]
        public string Details { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public string Category { get; set; }

    }

