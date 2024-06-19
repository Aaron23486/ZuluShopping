using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;

namespace ZuluShooping.Data.Entities
{
    public class Canton
    {
        public int Id { get; set; }

        [Display(Name = "Cantón")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public Province Province { get; set; }
    }
}
