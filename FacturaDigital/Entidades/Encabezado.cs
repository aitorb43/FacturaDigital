using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{

    public class Encabezado
    {

        public IdentificacionDocumento IdentificacionDocumento { get; set; }
        public Vendedor Vendedor { get; set; }
        public Comprador Comprador { get; set; }
        public String SujetoRetenido { get; set; }
        //public InformacionesAdicionales InformacionesAdicionales { get; set; }
        public Totales Totales { get; set; }
        
        public String TotalesRetencion { get; set; }


    }
}
