using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class FoliosController : Controller
    {

        /*
        http://localhost:5000/api/folios/:id
        Obtiene la información del Folio dado a un Id especificado 
         */
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // Verifica si existe el id especificado
            if (Datos.Folios.ContainsKey(id))
            {
                // Si el id es encontrado regresa el elemento de nuestro IDictionary en la posición especificada
                return Ok(Datos.Folios[id]);
            }
            else
            {
                // Si el id no es encontrado, regresa un 404
                return NotFound();
            }
        }
    }
}