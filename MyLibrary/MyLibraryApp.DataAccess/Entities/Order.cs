using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReurnDate { get; set; }
        public string Details { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int StatusId { get; set; }
    }
}
