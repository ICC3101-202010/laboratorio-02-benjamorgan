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
        public Cancion[] CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> Temporal = new List<Cancion>();
            switch (criterio)
            {
                case "Nombre":
                    foreach (Cancion item in ListDeCanciones)
                    {
                       if (item.Nombre == valor)
                        {
                            Temporal.Add(item);
                        }
                    }
                    
                      break;

                case "Genero":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.Genero == valor)
                        {
                            Temporal.Add(item);
                        }
                    }


                    break;
                case "Artista":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.Artista == valor)
                        {
                            Temporal.Add(item);
                        }
                    }


                    break;
                case "Album":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.Album == valor)
                        {
                            Temporal.Add(item);
                        }
                    }


                    break;




                default:
                    Console.WriteLine("el criterio no es valido");
                    break;
            }

            Cancion[] arraysongs = new Cancion[Temporal.Count];
            foreach (Cancion song  in Temporal)
            {
                Console.WriteLine(song.Informacion());
                arraysongs.Append(song);
            }
            if (arraysongs.Length == 0)
                Console.WriteLine("no hay canciones con el valor pedido");

            return arraysongs;
            // no uso lo que me devuelve el return, debido a que se imprime la informacion antes de la manera solicitada
            // al imprimirlo al mismo tiempo que separo por criterio, funciona de la manera solicitada.

            


        }



    }


}

