namespace MyLibrary.WebUI.Models;
using System.ComponentModel.DataAnnotations;

    public class CreateUserRequestModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

