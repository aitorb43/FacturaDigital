namespace FacturaDigital.Entidades
{
    public class CorreoEnvios
    {
        public string serie { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public List<string> correos { get; set; }

    }
}
