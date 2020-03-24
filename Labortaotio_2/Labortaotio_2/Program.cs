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
            string menu = "2";

            while(menu != "9")
            {
                menu = Console.ReadLine();
                if (menu == "1")
                {

                }

            }
            
            Cancion cancion1 = new Cancion("Red Moon", "Another Ark", "Uroboros", "Rock");
            Espotifai k = new Espotifai();
            k.AgregarCancion(cancion1);
            Console.WriteLine(k.AgregarCancion(cancion1));
            Console.WriteLine(cancion1.Informacion());
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
