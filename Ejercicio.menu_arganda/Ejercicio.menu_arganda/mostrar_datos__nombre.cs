using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.menu_arganda
{
    class mostrar_datos__nombre
    {
        public static void main()
        {
        buscarNombre:
            bool check;
            string buscar;
            Console.WriteLine("escribe para buscar");
            buscar = Console.ReadLine();
            for(int i=0;i<100;i++)
            {
               check = archivo[i].nombre.Contains(buscar);
                if (check = true)
                {
                    Console.WriteLine("{0},{1}, este es el archivo", archivo[i].nombre, archivo[i].tamaño);
                }
            }
          
            Console.ReadLine();
          
           
         
        }
    }
}
