using System.ComponentModel.DataAnnotations;
namespace WebServer.Models{
    public class SmartWatch{
        [Required]
        public long tiempo{get; set;}

        [Required]
        public float promedio {get; set;}

        [Required]
        public string fecha {get; set;}


    }
}