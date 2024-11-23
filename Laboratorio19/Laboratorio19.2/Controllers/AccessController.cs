using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace Laboratorio19._2.Controllers
{
    public class AccessController : ApiController
    {
        private readonly ApiClient cliente;

        public AccessController()
        {
            this.cliente = new ApiClient();
        }

        [HttpGet]
        [Route("Values")]
        public async Task<IHttpActionResult> GetValues()
        {
            string response = await cliente.GetAsync();

            if (string.IsNullOrEmpty(response))
            {
                return Content(HttpStatusCode.InternalServerError, "No se pudo obtener respuesta del API.");
            }

            // Parsear el JSON (opcional)
            try
            {
                JArray jsonResponse = JArray.Parse(response);
                return Ok(jsonResponse); // Devuelve los datos en formato JSON
            }
            catch
            {
                return BadRequest("La respuesta no es un JSON válido.");
            }
        }
    }
}


