using FacturaDigital.Entidades;
using FacturaDigital.Modelo;

namespace FacturaDigital.Interfaces
{
    public interface IFacturaDigitalService
    {
        public Task<ResultadoCredenciales> Autenticar(Credenciales credenciales);
    }
}
