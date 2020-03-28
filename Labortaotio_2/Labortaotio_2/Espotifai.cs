using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Espotifai

    {
        private List<Cancion> ListDeCanciones = new List<Cancion>();
        public List<Cancion> listDeCanciones
        {
            get => ListDeCanciones;
            set => ListDeCanciones = listDeCanciones;
        }
        private List<Playlist> ListDePlaylist = new List<Playlist>();
        public List<Playlist> listDePlaylist
        {
            get => ListDePlaylist;
            set => ListDePlaylist = listDePlaylist;
        }



        public Espotifai()
        {

        }
        public bool AgregarCancion(Cancion cancion)
        {

            int com = 1;

            foreach (Cancion igualdad in ListDeCanciones)
            {
                if (igualdad.Informacion() == cancion.Informacion())
                {
                    com = 0;
                }
            }
            if (com ==1)
            {
                Console.WriteLine("La cancion se agrego con exito");
                ListDeCanciones.Add(cancion);
                return true;

            }
            else
            {
                Console.WriteLine("la cancion ya esta en el repertorio");
                return false;
            }
                

        }
        public void VerCanciones()
        {
           foreach (Cancion cancion in ListDeCanciones)
            {

                Console.WriteLine(cancion.Informacion());
            }
        }
        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> Temporal = new List<Cancion>();
            switch (criterio)
            {
                case "Nombre":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.nombre == valor)
                        {
                            Temporal.Add(item);

                        }
                    }

                    break;
                case "Genero":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.genero == valor)
                        {
                            Temporal.Add(item);

                        }
                    }

                    break;
                case "Artista":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.artista == valor)
                        {
                            Temporal.Add(item);
 
                        }
                    }

                    break;
                case "Album":
                    foreach (Cancion item in ListDeCanciones)
                    {
                        if (item.album == valor)
                        {
                            Temporal.Add(item);

                        }
                    }
 
                    break;

                default:
                    Console.WriteLine("el criterio no es valido");
                    break;
            }
            
            if (Temporal.Count == 0)
                Console.WriteLine("no hay canciones con el valor pedido");

            return Temporal;


            


        }


        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            bool safe = true;
            foreach (Playlist play in ListDePlaylist)
            {
               if (play.nombre == nombrePlaylist)
                {
                    safe = false;
                }
            }
            if (safe)
            {
                if (CancionesPorCriterio(criterio, valorCriterio).Count != 0)
                {
                    Playlist autoplay = new Playlist(nombrePlaylist);
                    foreach (Cancion item in CancionesPorCriterio(criterio, valorCriterio))
                    {
                        autoplay.plist.Add(item);
                        
                    }
                    ListDePlaylist.Add(autoplay);
                    Console.WriteLine("La playlist se agrego exitosamente");
                    return true;
                }
                else
                {
                    Console.WriteLine("No hay canciones para este criterio");
                    return false;
                }


            }
            Console.WriteLine("la playlist ya existe");
            return false;


            

        }

        public string VerMisPlaylists()
        {

            return "";
        }






    }


}

