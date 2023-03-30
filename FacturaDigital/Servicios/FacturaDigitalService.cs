using FacturaDigital.Entidades;
using FacturaDigital.Interfaces;
using FacturaDigital.Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace FacturaDigital.Servicios
{
    public class FacturaDigitalService : IFacturaDigitalService
    {
        private static String _usuario;
        private static String _clave;
        private static String _baseUrl;
        private static String _token;

        public FacturaDigitalService() 
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _usuario = builder.GetSection("ApiSettings:usuario").Value;
            _clave = builder.GetSection("ApiSettings:clave").Value;
            _baseUrl = builder.GetSection("ApiSettings:baseUrl").Value;
        }

        public async Task<ResultadoCredenciales> Autenticar(Credenciales credenciales)
        {
            var cliente = new HttpClient();

            cliente.BaseAddress = new Uri(_baseUrl);

            // var credenciales = new Credenciales() { usuario = _usuario, clave = _clave };
            //var credenciales = new Credenciales() { usuario = credenciales.usuario, clave = _clave };

            var content = new StringContent(JsonConvert.SerializeObject(credenciales), Encoding.UTF8, "application/json");
            var response = await cliente.PostAsync("api/Autenticacion", content);
            var json_respuesta = await response.Content.ReadAsStringAsync();

            var resultado = JsonConvert.DeserializeObject<ResultadoCredenciales>(json_respuesta);
            _token = resultado.token;

            return resultado;
        }

        public async Task<String> Emision()
        {
            String lista = null;

            /*
             * await Autenticar();
           
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            var emision = new Emision() { usuario = _usuario, clave = _clave };

            var content = new StringContent(JsonConvert.SerializeObject(emision), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/Producto/Lista", content);

            if (response.IsSuccessStatusCode)
            {

                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoEmision>(json_respuesta);
                lista = resultado.lista;
            }
            */

            return lista;
        }

        }
}
