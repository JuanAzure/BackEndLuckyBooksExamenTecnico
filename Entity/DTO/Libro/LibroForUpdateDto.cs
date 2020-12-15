
using System.ComponentModel.DataAnnotations;

namespace Entity.DTO
{    
   public class LibroForUpdateDto : LibroForValidatorDto
    {
        [Required(ErrorMessage = "El codigo de Libro es requerido")]
        [Range(1, int.MaxValue,ErrorMessage = "El codigo de Libro mayor a 0")]
        public int codigoLibro { get; set; }        
    }
}
