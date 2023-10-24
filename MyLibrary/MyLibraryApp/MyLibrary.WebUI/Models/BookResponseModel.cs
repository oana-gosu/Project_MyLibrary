namespace MyLibrary.WebUI.Models
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public int? CategoryId { get; set; }
        //public int? PublishingHouseId { get; set; }
        //public int? PublishingYear { get; set; }
        public string Picture { get; set; }
        public int Stock { get; set; }
    }
}
