using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
         
        [HttpPost]
        public ActionResult Post([FromBody] PeticionFibonacci peticionFibonacci)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || peticionFibonacci == null)
            {
                return BadRequest();
            }
            else
            {
                int[] valores = new int[peticionFibonacci.iteraciones];
                if (peticionFibonacci.valorTotal == 0)
                {
                    valores[0] = 0;
                    valores[1] = 1;
                } else {
                    valores[0] = peticionFibonacci.valorPenultimo+peticionFibonacci.valorTotal;
                    valores[1] = peticionFibonacci.valorTotal+valores[0];
                }

                for (int i = 2; i < peticionFibonacci.iteraciones; i++)
                {
                    valores[i]=valores[i-1]+valores[i-2];
                }

                
                return Ok(valores);
            }
        }
    }
}