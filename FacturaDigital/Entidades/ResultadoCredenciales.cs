using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Entidades
{
    public class ResultadoCredenciales
    {
        
        public string codigo { get; set; }
        public string mensaje { get; set; }
        public string token { get; set; }
        public string expiracion { get; set; }
    }
}
