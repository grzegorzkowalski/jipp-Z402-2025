using System.ComponentModel.DataAnnotations;

namespace FilmDB2.Models
{
    public class FilmModel
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
