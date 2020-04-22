using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.menu_arganda
{
    class añadir_elemento
    {
        static void Main(string[] args)
        {
        añadirArchivo:
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Escribe el nombre del archivo");
                archivo[i].nombre = Console.ReadLine();
                Console.WriteLine("Escribe el tamaño del archivo");
                archivo[i].tamaño = Console.ReadLine();

            }
        }
    }
}
