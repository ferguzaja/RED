using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{

    /*
    Modelo de datos que especifican el formato del objeto para el Login
     */
    public class Login
    {
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }



    }
}