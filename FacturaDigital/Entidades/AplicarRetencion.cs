namespace FacturaDigital.Entidades
{
    public class AplicarRetencion
    {
        public string serie { get; set; }
        public string numeroDocumento { get; set; }
        public string numeroControl { get; set; }
        public totalRetencion totalRetencion { get; set; }
    }
}
