using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{

    /*
    Modelo de datos que representa la entidad Folio
     */
    public class Folio
    {
        public int NumFolio { get; set; }
        
        public decimal Monto { get; set; }

    }
}