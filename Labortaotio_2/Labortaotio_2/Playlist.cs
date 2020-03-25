using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Playlist
    {

        public string Nombre;
        public List<Cancion> Plist = new List<Cancion>();

        public Playlist(string aNombre)
        {
            Nombre = aNombre;

        }

        public void Informacion()
        {
            Console.WriteLine("Nombre de la playlist: "+Nombre);
            foreach  (Cancion song in Plist)
            {
                Console.WriteLine(song.Informacion()); 
            }

        }






    }
}
