using FacturaDigital.Entidades;
using FacturaDigital.Interfaces;
using FacturaDigital.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace FacturaDigital.Controllers
{
    public class FacturaDigitalController : Controller
    {
        private IFacturaDigitalService facturaDigitalService;

        public FacturaDigitalController(IFacturaDigitalService facturaDigitalService)
        {
            this.facturaDigitalService = facturaDigitalService;
        }

        [HttpPost("[controller]/Autenticacion")]
        public Task<ResultadoCredenciales> Autenticacion([FromBody] Credenciales credenciales)
        {
            var result = facturaDigitalService.Autenticar(credenciales);

            return result;
        }
    }
}
