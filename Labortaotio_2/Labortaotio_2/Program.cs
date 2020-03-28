using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labortaotio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido Nuevo usuario, que desea hacer hoy?");

            
            
            int numcase = 0;
            Espotifai k = new Espotifai();


            while (numcase != 9)
            {

                Console.WriteLine("");
                Console.WriteLine("Ver todas las canciones (1)");
                Console.WriteLine("Agregar una cancion (2)");
                Console.WriteLine("Buscar canciones por criterio (3)");
                Console.WriteLine("Crear playlist (4)");
                Console.WriteLine("Ver mis playlist (5)");
                Console.WriteLine("Salir del programa (9)");
                string respuesta = Console.ReadLine();
                numcase = Convert.ToInt32(respuesta);

                switch (numcase)

                {
                    case 1:
                        {
                            k.VerCanciones();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nombre de la cancion?");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Artista de la cancion?");
                            string arti = Console.ReadLine();
                            Console.WriteLine("Genero de la cancion?");
                            string gen = Console.ReadLine();
                            Console.WriteLine("Album de la cancion?");
                            string alb = Console.ReadLine();
                            Cancion Temp = new Cancion(nom, alb, arti, gen);
                            k.AgregarCancion(Temp);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese un Criterio (Genero,Album,Artista,Nombre)");
                            string crit = Console.ReadLine();
                            Console.WriteLine("Ingrese un valor");
                            string val = Console.ReadLine();
                            k.CancionesPorCriterio(crit, val);

                            break;
                        }
                    case 4:

                        {
                            Console.WriteLine("Ingrese el nombre de la playlist que desea crear");
                            string nomplay = Console.ReadLine();
                            Console.WriteLine("Ingrese un Criterio (Genero,Album,Artista,Nombre)");
                            string crit = Console.ReadLine();
                            Console.WriteLine("Ingrese un valor");
                            string val = Console.ReadLine();
                            k.GenerarPlaylist(crit,val,nomplay);

                            break;
                        }
                    case 5:
                        {
                            foreach (Playlist playlists in k.listDePlaylist)
                            {
                                playlists.Informacion();
                            }
                            break;
                        }

                        
                    case 9:
                        {

                            break;
                        }
                    default:
                        Console.WriteLine("Numero no valido");
                        break;
                }
            }

            


            Console.ReadLine();
        }
    }
}
