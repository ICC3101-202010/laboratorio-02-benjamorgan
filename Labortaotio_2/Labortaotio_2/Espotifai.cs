using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Espotifai
 
    {
        public Cancion[] ListaDeCanciones = new Cancion[] { };
        public Espotifai()
        {

        }
        public bool AgregarCancion(Cancion cancion)
        {
            if (Array.Exists(ListaDeCanciones, element => element.Nombre ==cancion.Nombre) && Array.Exists(ListaDeCanciones, element => element.Artista == cancion.Artista && Array.Exists(ListaDeCanciones, elemen => elemen.Genero == cancion.Genero)))
            {
                return false;
            }

            else
            {
                ListaDeCanciones.Append(cancion);
                Console.WriteLine(ListaDeCanciones[0]);
                return true;

            }
             void VerCanciones()
            {
                //Console.WriteLine(canciones);
            }
        }
    }


    }

