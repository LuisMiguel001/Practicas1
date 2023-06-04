using System.ComponentModel.DataAnnotations;

namespace Practicas1.Models
{
    public class Pruebas
    {
        [Key]

        public int PruebaId { get; set; }

        [Required (ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
    }
}
