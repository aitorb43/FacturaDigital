using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
    public class Credenciales
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        public string usuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(250)]
        public string clave { get; set; }
    }
}
