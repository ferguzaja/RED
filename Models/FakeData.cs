using System.Collections.Generic;

namespace WebServer.Models {
    public class FakeData {
        public static IDictionary<int, VideoMusical> Videos { get; private set; }

        static FakeData() {
            Videos = new Dictionary<int, VideoMusical>();
            Videos.Add(0, new VideoMusical { ID = 0, Nombre = "Dura", Artista = "Daddy Yankee", Vistas = "388,148,451" });
            Videos.Add(1, new VideoMusical { ID = 1, Nombre = "Corazón (Official Video) ft. Nego do Borel", Artista = "Maluma", Vistas = "744,840,328" });
            Videos.Add(2, new VideoMusical { ID = 2, Nombre = "Échame La Culpa", Artista = "Luis Fonsi, Demi Lovato", Vistas = "1,003,594,226" });
            Videos.Add(3, new VideoMusical { ID = 3, Nombre = "Mayores", Artista = "Becky G, Bad Bunny", Vistas = "1,061,942,606" });
        }
    }
}