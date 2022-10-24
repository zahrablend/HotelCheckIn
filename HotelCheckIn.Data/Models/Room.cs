using System.ComponentModel.DataAnnotations;

namespace HotelCheckIn.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        public List<Guest>? Guests { get; set; }
    }
}