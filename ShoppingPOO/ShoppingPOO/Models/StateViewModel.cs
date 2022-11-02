using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingPOO.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "State")]
        [MaxLength(100, ErrorMessage = "Field {0} must have at least {1} character.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
