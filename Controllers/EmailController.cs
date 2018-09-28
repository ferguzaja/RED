using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
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
            return Ok(Datos.DatosEmail);
        }
        [HttpPost]
        public ActionResult Post([FromBody]Email email){
            if(!this.ModelState.IsValid||email==null){
                return BadRequest();
            }else{
                //TODO: hacer tal cosa
                Datos.DatosEmail.Add(Datos.DatosEmail.Count,email);
                return Ok(email);
                //TODO: validar aqui
            }
        }
    }
}