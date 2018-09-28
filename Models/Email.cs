using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{

    /*
    Modelo de datos que representa la entidad Folio
     */
    public class Email
    {
        public int id { get; set; }
        
        public string Remitente { get; set; }

        public string Destinatario { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

    }
}