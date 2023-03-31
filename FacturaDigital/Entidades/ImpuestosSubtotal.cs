using System.ComponentModel.DataAnnotations;

namespace FacturaDigital.Modelo
{
    public class ImpuestosSubtotal
    {
       public String CodigoTotalImp { get; set; }
       public String AlicuotaImp { get; set;  }
       public String BaseImponibleImp { get; set;  }
       public String ValorTotalImp { get; set;  }

    }
}
