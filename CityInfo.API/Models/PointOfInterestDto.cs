using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "Please provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "The field description must be a string with maximum length of 200")]
        public string Description { get; set; }

    }

    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "Please provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "The field description must be a string with maximum length of 200")]
        public string Description { get; set; }

    }
}
