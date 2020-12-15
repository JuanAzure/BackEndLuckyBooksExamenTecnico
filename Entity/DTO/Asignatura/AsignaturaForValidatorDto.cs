using System.ComponentModel.DataAnnotations;
namespace Entity.DTO
{
    public abstract class AsignaturaForValidatorDto
    {
        [Required(ErrorMessage = "La descripcion es requerido")]
        [MaxLength(120, ErrorMessage = "Maximum length for the Name is 120 characters.")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "La condicion es requerido")]
        public bool condicion { get; set; }
    }
}
