using Ejercicio_Repaso.Entidades;
using Ejercicio_Repaso.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InterfazMenu menu = new ImplMenu();
                InterfazEmpleado empleado = new ImplEmpleado();

                List<Empleado> empleados = new List<Empleado>();


                int opcion;
                do
                {
                    opcion = menu.Menu();
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            empleado.RegistrarEmpleado(empleados);
                            break;
                        case 2:
                            empleado.ModificarEmpleado(empleados);
                            break;
                        case 3:
                            empleado.Exportar(empleados);
                            break;
                    }
                } while (opcion != 4);

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
