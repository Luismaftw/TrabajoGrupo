using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.menu_arganda
{
    class menu
    {
        struct tipoarchivo
        {
            public string nombre;
            public int tamaño;
        }
        public static void main()
        {
            mostrar_datos__tamaño tamaño = new mostrar_datos__tamaño();
            tipoarchivo[] achivo = new tipoarchivo[100];
            int menu;
            do
            {
                Console.WriteLine("pulsa 1 para añadir , 2 para mostrar datos , 3 para buscar un tamaño , 4 para buscar un nombre , 5 para salir");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                       goto añadirArchivo;
                        break;
                    case 2:
                        goto MostrarArchivo;
                        break;
                    case 3:
                       goto mostrartamaño;
                        break;
                    case 4:
                      goto mostrarnombre;
                        break;
                    case 5:
                        goto salir;
                        break;
                }

            }
            while (menu < 5);
            Console.ReadLine();
        }
    }
}
