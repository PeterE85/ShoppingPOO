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
        
        public ICollection<State> States { get; set; }


        [Display(Name = "States")]
        public int StatesNumber => States == null ? 0 : States.Count; //propiedad de lectura si es nulo devuelve 0 sino que devuelva los ESTADOS
    }
}
