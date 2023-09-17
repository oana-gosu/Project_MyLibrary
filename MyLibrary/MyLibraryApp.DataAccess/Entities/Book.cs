﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DataAccess.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public int? CategoryId { get; set; }
        public int? PublishingHouseId { get; set; }
        public int? PublishingYear { get; set; }
        public byte[]? Picture { get; set; }
        public int Stock { get; set; }  

    }
}
