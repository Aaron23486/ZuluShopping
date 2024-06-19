using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZuluShooping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        // Propiedad que representa la colección de provincias asociadas al país.
        public ICollection<Province> Provinces { get; set; }

        // Propiedad de solo lectura que devuelve el número de provincias.
        [Display(Name = "Provincias")]
        public int ProvincesNumber => Provinces == null ? 0 : Provinces.Count;
    }
}
