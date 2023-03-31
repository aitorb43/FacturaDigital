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

        [HttpPost("[controller]/Emision")]
        public Task<ResultadoEmision> Emision()
        {
            // Documento de venta 

            #region Cuerpo de documento FACT / NCR 
            Cuerpo cuerpo = new Cuerpo()
            {

                documentoElectronico = new DocumentoElectronico()

            };

            cuerpo.documentoElectronico.Encabezado = new Encabezado()
            {
                IdentificacionDocumento = new IdentificacionDocumento()
                {
                    TipoDocumento = "01",
                    NumeroDocumento = "00030127",
                    FechaEmision = "20/01/2023",
                    FechaVencimiento = "31/12/2023",
                    HoraEmision = "09:55:00 am",
                    TipoDePago = "importado",
                    Serie = "A",
                    Sucursal = "0001",
                    TipoDeVenta = "interna",
                    Moneda = "BsD"



                },
                Vendedor = new Vendedor()
                {

                    Codigo = "A01",
                    Nombre = "Nombre",
                    NumCajero = "NumCajero"



                },


                Comprador = new Comprador()
                {
                    TipoIdentificacion = "J",
                    NumeroIdentificacion = "26159207-6",
                    RazonSocial = "Eduardo Montiel",
                    Direccion = "Av Principal de algun sitio",
                    Pais = "VE"
                },


                Totales = new Totales()
                {
                    NroItems = "2",
                    MontoGravadoTotal = "10.00",
                    Subtotal = "10.00",
                    TotalAPagar = "11.60",
                    TotalIVA = "11.60",
                    MontoTotalConIVA = "11.60",
                    MontoEnLetras = "ONCE BOLIVARES CON SESENTA CENTIMOS",
                    TotalDescuento = null,
                    ListaDescBonificacion = null,


                },

            };
            FormasPago item = new FormasPago()
            {
                Forma = "01",
                Monto = "20",
                Moneda = "BS"
            };

            ImpuestosSubtotal imp = new ImpuestosSubtotal()
            {
                CodigoTotalImp = "G",
                AlicuotaImp = "16.00",
                BaseImponibleImp = "10.00",
                ValorTotalImp = "1.60"
            };


            cuerpo.documentoElectronico.Encabezado.Totales.ImpuestosSubtotal = new List<ImpuestosSubtotal>();
            cuerpo.documentoElectronico.Encabezado.Totales.ImpuestosSubtotal.Add(imp);

            cuerpo.documentoElectronico.Encabezado.Totales.FormasPago = new List<FormasPago>();
            cuerpo.documentoElectronico.Encabezado.Totales.FormasPago.Add(item);

            cuerpo.documentoElectronico.Encabezado.Comprador.Telefono = new List<string>();

            cuerpo.documentoElectronico.Encabezado.Comprador.Telefono.Add("809-472-7676");
            cuerpo.documentoElectronico.Encabezado.Comprador.Telefono.Add("809-491-1918");

            DetallesItem detalles = new DetallesItem()
            {
                NumeroLinea = "1",

                CodigoPLU = "7591",

                IndicadorBienoServicio = "1",
                Descripcion = "Refresco PET 500 ml",
                Cantidad = "2",
                UnidadMedida = "NIU",
                PrecioUnitario = "5.00",

                PrecioItem = "10.00",
                CodigoImpuesto = "G",
                TasaIVA = "16.00",
                ValorIVA = "1.60",
                ValorTotalItem = "11.60",

            };

            cuerpo.documentoElectronico.DetallesItems = new List<DetallesItem>();
            cuerpo.documentoElectronico.DetallesItems.Add(detalles);




            //InfoAdicional InfoAdicional = new InfoAdicional()
            //{


            //}


            #endregion


            var result = facturaDigitalService.Emision(cuerpo);

            return result;
        }

        [HttpPost("[controller]/Anular")]
        public Task<ResultadoRetencionCorreoAnular> Anular([FromBody] Anular anular)
        {
            var result = facturaDigitalService.Anular(anular);

            return result;
        }

        [HttpPost("[controller]/AplicarRetencion")]
        public Task<ResultadoRetencionCorreoAnular> AplicarRetencion([FromBody] AplicarRetencion aplicarRetencion)
        {
            var result = facturaDigitalService.AplicarRetencion(aplicarRetencion);

            return result;
        }

        [HttpPost("[controller]/CorreoEnvios")]
        public Task<ResultadoRetencionCorreoAnular> CorreoEnvios([FromBody] CorreoEnvios correoEnvios)
        {
            var result = facturaDigitalService.CorreoEnvios(correoEnvios);

            return result;
        }

        [HttpPost("[controller]/CorreoRastreo")]
        public Task<ResultadoCorreoRastreo> CorreoRastreo([FromBody] CorreoRastreo correoRastreo)
        {
            var result = facturaDigitalService.CorreoRastreo(correoRastreo);

            return result;
        }




    }
}
