namespace FacturaDigital.Entidades
{
    public class ResultadoCorreoRastreo
    {
        
        public string codigo { get; set; }
        public string mensaje { get; set; }
        public List<rastreos> rastreos { get; set; }
    }
}
