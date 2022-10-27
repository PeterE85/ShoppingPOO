using System.ComponentModel.DataAnnotations;

namespace ShoppingPOO.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Country")]
        [MaxLength(100, ErrorMessage = "Field {0} has to be at least {1} caracters.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }
    }
}
