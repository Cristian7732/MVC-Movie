using System.ComponentModel.DataAnnotations;

namespace MVC_Movie.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Release_Date { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
