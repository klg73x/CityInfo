using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is a required field.")] //This puts the error back in the model state send
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
