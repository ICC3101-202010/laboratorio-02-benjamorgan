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
            Console.WriteLine("Ver todas las canciones (1)");
            Console.WriteLine("Agregar una cancion (2)");
            Console.WriteLine("Salir del programa (9)");
            Cancion cancion1 = new Cancion("Red Moon", "Another Ark", "Uroboros", "Rock");
            
            int numcase = 0;
            Espotifai k = new Espotifai();
            k.AgregarCancion(cancion1);

            while (numcase != 9)
            {
                string respuesta = Console.ReadLine();
                numcase = Convert.ToInt32(respuesta);
                switch (numcase)
                {
                    case 1:
                        {
                            k.VerCanciones();
                            Console.WriteLine("Desea hacer otra operacion?");
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
                            Console.WriteLine("Desea hacer otra operacion?");
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
