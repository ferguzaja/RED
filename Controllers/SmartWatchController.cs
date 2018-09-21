using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class SmartWatchController : Controller
    {

        /*
        http://localhost:5000/api/usuarios/:id
        Obtiene la información del smartWatch dado a un Id especificado 
         */
         
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // Verifica si existe el id especificado
            if (Datos.Usuarios.ContainsKey(id))
            {
                // Si el id es encontrado regresa el elemento de nuestro IDictionary en la posición especificada
                return Ok(Datos.Usuarios[id]);
            }
            else
            {
                // Si el id no es encontrado, regresa un 404
                return NotFound();
            }
        }

        [HttpGet]
        public ActionResult Get(){
            return Ok(Datos.DatosSmartWatch);
        }
        [HttpPost]
        public ActionResult Post([FromBody]SmartWatch smartWatch){
            if(!this.ModelState.IsValid||smartWatch==null){
                return BadRequest();
            }else{
                //TODO: hacer tal cosa
                Datos.DatosSmartWatch.Add(Datos.DatosSmartWatch.Count,smartWatch);
                return Ok(smartWatch);
                //TODO: validar aqui
            }
        }
    }
}