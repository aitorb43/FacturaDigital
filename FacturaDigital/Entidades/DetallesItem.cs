using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
    public class DetallesItem
    {
        public String NumeroLinea { get; set; }
        public String CodigoCIIU { get; set; }
        public String CodigoPLU { get; set; }
        public String IndicadorBienoServicio { get; set; }
        public String Descripcion { get; set; }
        public String Cantidad { get; set; }
        public String UnidadMedida { get; set; }
        public String PrecioUnitario { get; set; }
        public String PrecioUnitarioDescuento { get; set; }
        public String MontoBonificacion { get; set; }
        public String DescripcionBonificacion { get; set; }
        public String DescuentoMonto { get; set; }
        public String PrecioItem { get; set; }
        public String CodigoImpuesto { get; set; }
        public String TasaIVA { get; set;  }
        public String ValorIVA { get; set;  }
        public String ValorTotalItem { get; set; }
        public String InfoAdicionalItem { get; set; }
        public String ListaItemOTI { get; set; }

        public static implicit operator List<object>(DetallesItem v)
        {
            throw new NotImplementedException();
        }
    }
}
