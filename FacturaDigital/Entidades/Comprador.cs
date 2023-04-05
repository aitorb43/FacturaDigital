using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Entidades
{
    public class Comprador
    {
        public String TipoIdentificacion { get; set; }
        public String NumeroIdentificacion { get; set; }
        public String RazonSocial { get; set; }

        public String Direccion { get; set; }
        public String Pais { get; set; }

        public List<string> Telefono { get; set; }

        public List <string> Correo { get; set;  }

 
    }
}
