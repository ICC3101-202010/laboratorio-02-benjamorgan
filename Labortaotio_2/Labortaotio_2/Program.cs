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
            string menu = Console.ReadLine();


            



            Cancion cancion1 = new Cancion("Red Moon", "Another Ark", "Uroboros", "Rock");
            Console.WriteLine(cancion1.Informacion());


            Console.ReadLine();
        }
    }
}
