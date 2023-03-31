using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
    public class Totales
    {
        public String NroItems { get; set; }
        public String MontoGravadoTotal { get; set; }
        public String  MontoExentoTotal { get; set; }
        public String    Subtotal { get; set; }
        public String    TotalAPagar { get; set; }
        public String    TotalIVA { get; set; }
        public String    MontoTotalConIVA { get; set;  }
        public String    MontoEnLetras { get; set; }
        public String    TotalDescuento { get; set; }
        public String    ListaDescBonificacion { get; set;  }

        public List<ImpuestosSubtotal> ImpuestosSubtotal { get; set;  }

        public List<FormasPago> FormasPago { get; set;  }



    }
}
