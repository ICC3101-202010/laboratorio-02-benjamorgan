using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Espotifai

    {
        public List<Cancion> ListDeCanciones = new List<Cancion>();

        public Espotifai()
        {

        }
        public bool AgregarCancion(Cancion cancion)
        {
            if (ListDeCanciones.Contains(cancion))
            {
                return false;
            }

            else
            {
                ListDeCanciones.Add(cancion);
                return true;

            }

        }
        public void VerCanciones()
        {
           foreach (Cancion cancion in ListDeCanciones)
            {

                Console.WriteLine(cancion.Informacion());
            }
        }
    }


}

