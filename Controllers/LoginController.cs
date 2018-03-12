using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {

        /*
        http://localhost:5000/api/Login
        Compara el objeto login para ver si es un usuario existente 
        */
        [HttpPost]
        public ActionResult Post([FromBody]Login login)
        {
            // Si el modelo (login) es inválido o es null, regresa un 400
            if (!this.ModelState.IsValid || login == null)
            {
                return BadRequest();
            }
            else
            {
                // Busca el login  en el IDictionary 
                Usuario usuario = Datos.Usuarios.FirstOrDefault(x => x.Value.Email.Equals(login.Email) && x.Value.Password.Equals(login.Password)).Value;
                if (usuario != null)
                {
                    // Si es encontrado regresa la variable usuario
                    return Ok(usuario);
                }
                else
                {
                    // Si no es encontrado, regresa un 404
                    return NotFound();
                }


            }
        }
    }
}