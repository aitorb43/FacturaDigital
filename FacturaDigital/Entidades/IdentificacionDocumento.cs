using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
 
    public class IdentificacionDocumento
    {
        #region Propiedades 
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoProveedor { get; set; }
        public string TipoTransaccion { get; set; }
        public string NumeroPlanillaImportacion { get; set; }
        public string NumeroExpedienteImportacion { get; set; }
        public string SerieFacturaAfectada { get; set; }
        public string NumeroFacturaAfectada { get; set; }
        public string FechaFacturaAfectada { get; set; }
        public string MontoFacturaAfectada { get; set; }
        public string ComentarioFacturaAfectada { get; set; }
        public string RegimenEspTributacion { get; set; }
        public string FechaEmision { get; set; }
        public string FechaVencimiento { get; set; }
        public string HoraEmision { get; set; }
        public string Anulado { get; set; }
        public string TipoDePago { get; set; }
        public string Serie { get; set; }
        public string Sucursal { get; set; }
        public string TipoDeVenta { get; set; }
        public string Moneda { get; set; }


        #endregion
    }

}
