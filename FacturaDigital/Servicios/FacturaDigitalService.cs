using FacturaDigital.Entidades;
using FacturaDigital.Interfaces;
using FacturaDigital.Modelo;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ResultadoEmision> Emision(Cuerpo cuerpo)
        {
            String lista = null;

            // var a = Autenticar();

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);

            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);


            var content = new StringContent(JsonConvert.SerializeObject(cuerpo), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/Emision", content);

            var json_respuesta = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ResultadoEmision>(json_respuesta);


            return resultado;
        }

        public async Task<ResultadoRetencionCorreoAnular> Anular(Anular anular)
        {

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            //ResultadoAnular resultado = new ResultadoAnular();

            var content = new StringContent(JsonConvert.SerializeObject(anular), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/Anular", content);

            //          if (response.IsSuccessStatusCode)
            //           {

            var json_respuesta = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ResultadoRetencionCorreoAnular>(json_respuesta); ;
            //           }

            return resultado;

        }

        public async Task<ResultadoRetencionCorreoAnular> AplicarRetencion(AplicarRetencion aplicarRetencion)
        {

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var content = new StringContent(JsonConvert.SerializeObject(aplicarRetencion), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/AplicarRetencion", content);

            //          if (response.IsSuccessStatusCode)
            //           {

            var json_respuesta = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ResultadoRetencionCorreoAnular>(json_respuesta); ;
            //           }

            return resultado;

        }

        public async Task<ResultadoRetencionCorreoAnular> CorreoEnvios(CorreoEnvios correoEnvios)
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var content = new StringContent(JsonConvert.SerializeObject(correoEnvios), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/Correo/Enviar", content);


            var json_respuesta = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ResultadoRetencionCorreoAnular>(json_respuesta); ;

            return resultado;
        }

        public async Task<ResultadoCorreoRastreo> CorreoRastreo(CorreoRastreo correoRastreo)
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var content = new StringContent(JsonConvert.SerializeObject(correoRastreo), Encoding.UTF8, "application/json");

            var response = await cliente.PostAsync("api/Correo/Rastreo", content);


            var json_respuesta = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ResultadoCorreoRastreo>(json_respuesta); ;

            return resultado;
        }

    }
}
