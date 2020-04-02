using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(5)]
        public string ZIPCode { get; set; }

        public Location Location { get; set; }
    }
}
