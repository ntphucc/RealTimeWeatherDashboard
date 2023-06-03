using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class WeatherData
    {
        [Key]
        public int WeatherDataId { get; set; }
        public int LocationId { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        public double Temperature { get; set; }
        public int Humidity { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        public Location Location { get; set; }

    }
}
