using System.ComponentModel.DataAnnotations;

namespace ShoppingPOO.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Country")]
        [MaxLength(100, ErrorMessage = "Field {0} must have at least {1} character.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }        
    }
}
