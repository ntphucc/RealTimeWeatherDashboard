using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Weather
    {
        [Key]
        public int WeatherId { get; set; }
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
