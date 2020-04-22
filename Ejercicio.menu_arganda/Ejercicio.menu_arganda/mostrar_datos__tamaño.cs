using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.menu_arganda
{
    class mostrar_datos__tamaño
    {
        public static void main()
        {
            mostrartamaño:
            Console.WriteLine("introduce un tamaño para buscar");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                if (tamaño == archivo[i].tamaño)
                {
                    Console.WriteLine("este archivo coincide en tamaño");
                    Console.WriteLine("{0} , {1}", archivo[i].nombre, archivo[i].tamaño);
                }
            }
            Console.ReadLine();
        }
       
    }
}
