using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Cancion
    {
        private string Nombre;
        public string nombre
            {
            get => Nombre;
            set => Nombre = nombre ;
            }

        private string Album;
        public string album
        {
            get => Album;
            set => Album =album ;
        }

        private string Artista;
        public string artista
        {
            get => Artista;
            set => Artista = artista;
        }

        private string Genero;
        public string genero
        {
            get => Genero;
            set => Genero = genero;
        }

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
