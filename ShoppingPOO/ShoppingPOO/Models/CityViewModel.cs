using ShoppingPOO.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingPOO.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        [MaxLength(100, ErrorMessage = "Field {0} must have at least {1} character.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }

        public int StateId { get; set; }
    }
}
