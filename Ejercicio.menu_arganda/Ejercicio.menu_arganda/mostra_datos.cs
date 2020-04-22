using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.menu_arganda
{
    class mostra_datos
    {
        static void Main(string[] args)
        {
        MostrarArchivo:
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0} {1}", archivo[i].nombre, archivo[i].tamaño);
            }



        }
    }
}
