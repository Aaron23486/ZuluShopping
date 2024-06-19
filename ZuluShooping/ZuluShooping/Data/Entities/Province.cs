using System.ComponentModel.DataAnnotations;

namespace ZuluShooping.Data.Entities
{
    public class Province
    {
        public int Id { get; set; }

        [Display(Name = "Provincia")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public Country Country { get; set; }

        // Propiedad que representa la colección de Cantones asociadas al una Provincia.
        public ICollection<Canton> Cantones { get; set; }

        // Propiedad de solo lectura que devuelve el número de Cantones.
        [Display(Name = "Cantones")]
        public int CantonesNumber => Cantones == null ? 0 : Cantones.Count;
    }
}
