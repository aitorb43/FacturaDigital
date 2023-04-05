namespace FacturaDigital.Entidades
{
    public class ResultadoEmision
    {
        
        public string codigo { get; set; }
        public string mensaje { get; set; }
        public List<string> validaciones { get; set; }
        public resultado resultado { get; set; }

    }
}
