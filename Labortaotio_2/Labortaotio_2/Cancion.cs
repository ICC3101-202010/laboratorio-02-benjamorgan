using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;

        public Cancion(string aNombre, string aAlbum, string aArtista, string aGenero)
        {
            Nombre = aNombre;
            Album = aAlbum;
            Artista = aArtista;
            Genero = aGenero;
        }
        public string Informacion()
        {
            return "genero: " + Genero + ", artista: " + Artista + ", album: " + Album + ", nombre: " + Nombre;
        }
    }
}
