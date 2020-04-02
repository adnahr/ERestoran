using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restoran.models
{
    public class Country
    {
       [Key]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }

        public Location Location { get; set; }

    }
}
