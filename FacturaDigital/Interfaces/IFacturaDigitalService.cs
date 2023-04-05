using FacturaDigital.Entidades;
using FacturaDigital.Modelo;

namespace FacturaDigital.Interfaces
{
    public interface IFacturaDigitalService
    {
        
        public Task<ResultadoCredenciales> Autenticar(Credenciales credenciales);
        public Task<ResultadoEmision> Emision(Cuerpo cuerpo);
        public Task<ResultadoRetencionCorreoAnular> Anular(Anular anular);
        public Task<ResultadoRetencionCorreoAnular> AplicarRetencion(AplicarRetencion aplicarRetencion);
        public Task<ResultadoRetencionCorreoAnular> CorreoEnvios(CorreoEnvios correoEnvios);
        public Task<ResultadoCorreoRastreo> CorreoRastreo(CorreoRastreo correoRastreo);


    }
}
