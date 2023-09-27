using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso.Servicios
{
    internal class ImplMenu:InterfazMenu
    {
        public int Menu()
        {
            Console.WriteLine("\n\tAdministrar Empleados");
            Console.WriteLine("\t----------------------");
            Console.WriteLine("\t1. Registrar Empleado");
            Console.WriteLine("\t2. Modificar Empleado");
            Console.WriteLine("\t3. Exportar a Fichero");
            Console.WriteLine("\t4. Salir");
            Console.Write("\n\tElige una opción:");
            int opcion = Console.ReadKey(true).KeyChar - '0';

            while (opcion < 1 || opcion > 4)
            {
                Console.Write("[Error] Introduce un número válido.");
                opcion = Console.ReadKey(true).KeyChar - '0';
            }
            return opcion;
        }
    }
}
