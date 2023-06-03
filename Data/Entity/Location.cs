using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public User User { get; set; }
        public ICollection<WeatherData> WeatherDataList { get; set; }

    }
}
