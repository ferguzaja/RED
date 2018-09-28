using System.ComponentModel.DataAnnotations;
namespace WebServer.Models
{

    /*
    Modelo de datos que representa la entidad Folio
     */
    public class PeticionFibonacci
    {   [Required]
        public int iteraciones { get; set; }

        [Required]
        public int valorTotal { get; set; }

        [Required]
        public int valorPenultimo { get; set; }

    }
}