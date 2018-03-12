using System.Collections.Generic;

namespace WebServer.Models
{
    public class Datos
    {

        /*
         IDictionary Representa una colección genérica de pares clave-valor.
         En este caso se crea un IDictionary de claves de tipo int, y valor de tipo Usuario
         */
        public static IDictionary<int, Usuario> Usuarios { get; private set; }

        /*
        Creamos un IDictionary para los datos de Folios
         */
        public static IDictionary<int, Folio> Folios { get; set; }

        // Constructor de la clase
        static Datos()
        {
            /*
            Se agregan tres entradas de clave-valor a nuestro IDictionary
             */
             //TODO: Agregar más datos de prueba
            Usuarios = new Dictionary<int, Usuario>();
            Usuarios.Add(0, new Usuario { ID = 0, Nombre = "Vlad", Apellidos = "Drăculea", Email = "alucard@gmail.com", Password = "123456" });
            Usuarios.Add(1, new Usuario { ID = 1, Nombre = "Dorian", Apellidos = "Gray", Email = "eternalLife@gmail.com", Password = "23435643" });
            Usuarios.Add(2, new Usuario { ID = 2, Nombre = "Jeanne", Apellidos = "d'Arc", Email = "DoncelladeOrleans@gmail.com", Password = "asdf445asd" });
        }
    }
}