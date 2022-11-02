using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingPOO.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Sate")]
        [MaxLength(100, ErrorMessage = "Field {0} must have at least {1} character.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }

        public Country Country { get; set; }
        public ICollection<City> Cities{ get; set; }

        [Display(Name = "Cities")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

    }
}
