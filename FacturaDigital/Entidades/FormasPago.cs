using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
    public class FormasPago
    {
        public String Descripcion { get; set; }
        public String  Fecha { get; set;  }
        public String   Forma { get; set; }
        public String   Monto { get; set;  }
        public String   Moneda { get; set; }
        public String    TipoCambio { get; set;  }

    }
}
