
using System.ComponentModel.DataAnnotations;

namespace Entity.DTO
{
    public abstract class LibroForValidatorDto
    {
        [Required(ErrorMessage = "La descripcion es requerido")]
        [MaxLength(120, ErrorMessage = "Maximum length for the Name is 120 characters.")]
        public string descripcion { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El codigo de Asignatura requerido tiene que ser mayor a 0")]
        public int asignatura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El stock mayor a 0")]
        public int stock { get; set; }
    }
}
