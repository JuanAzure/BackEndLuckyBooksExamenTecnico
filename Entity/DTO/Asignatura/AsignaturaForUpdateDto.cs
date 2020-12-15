using System.ComponentModel.DataAnnotations;
namespace Entity.DTO
{    
    public class AsignaturaForUpdateDto : AsignaturaForValidatorDto
    {
        [Required(ErrorMessage = "El codigo de Asignatura es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El codigo de Asignatura mayor a 0")]
        public int codigoAsignatura { get; set; }        
    }
}
