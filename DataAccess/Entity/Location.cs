using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
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
        public ICollection<Weather> WeatherDataList { get; set; }
    }
}
