using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Laboratorio19._2.Controllers
{
    public class AccessController : ApiController
    {
        private readonly ApiClient _cliente;

        public AccessController()
        {
            _cliente = new ApiClient();
        }

        // Endpoint: GET api/Access/GetValue/{id}
        [HttpGet]
        [Route("api/Access/GetValue/{id}")]
        public async Task<IHttpActionResult> GetValue(int id)
        {
            // Llama al método GetAsync para obtener la respuesta como cadena
            string response = await _cliente.GetAsync(id);

            if (string.IsNullOrEmpty(response))
            {
                return Content(HttpStatusCode.InternalServerError, "No se pudo obtener respuesta del API.");
            }

            // Retorna la cadena obtenida
            return Ok(response);
        }
    }
}
