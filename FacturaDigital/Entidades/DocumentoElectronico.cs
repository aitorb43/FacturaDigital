using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{

    public class DocumentoElectronico
    {
        public Encabezado Encabezado { get; set; }

        public List<DetallesItem> DetallesItems { get; set; }

        public String DetallesRetencion { get; set; }
        public String Viajes { get; set; }

        public List<InfoAdicional> InfoAdicional { get; set; }
    }
}
