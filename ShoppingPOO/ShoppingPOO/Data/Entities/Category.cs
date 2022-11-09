using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingPOO.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [MaxLength(100, ErrorMessage = "Field {0} must have at least {1} character.")]
        [Required(ErrorMessage = "Field {0} is mandatory!!!.")]
        public string Name { get; set; }
        //public List<State> States { get; internal set; }
    }
}
