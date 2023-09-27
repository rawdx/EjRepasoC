using Ejercicio_Repaso.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso.Servicios
{
    internal class ImplEmpleado:InterfazEmpleado
    {
        public int contador = 0;
        public void RegistrarEmpleado(List<Empleado> lista)
        {
            Console.Write("\n\tIntroduce el nombre:");
            string nombre = Console.ReadLine();

            Console.Write("\n\tIntroduce los apellidos:");
            string apellidos = Console.ReadLine();

            Console.Write("\n\tIntroduce el DNI:");
            string dni = Console.ReadLine();

            Console.Write("\n\tIntroduce la fecha de nacimiento:");
            string diaNac = Console.ReadLine();

            Console.Write("\n\tIntroduce la titulación:");
            string titulacion = Console.ReadLine();

            Console.Write("\n\tIntroduce el número de la seguridad social:");
            int.TryParse(Console.ReadLine(), out int numSegSoc);

            Console.Write("\n\tIntroduce el número de cuenta:");
            int.TryParse(Console.ReadLine(), out int numCuenta);

            int numEmpleado = ++contador;

            lista.Add(new Empleado (numEmpleado, nombre, apellidos, dni, diaNac, titulacion, numSegSoc, numCuenta));

            Console.Clear();
            Console.WriteLine("\n\tEl empleado se ha registrado correctamente.");
        }

        public void ModificarEmpleado(List<Empleado> lista)
        {
            Console.Write("\n\tIntroduce el número del empleado que quieres modificar: ");
            int.TryParse(Console.ReadLine(), out int numEmpleado);

            Console.Clear();
            bool existe = false;
            foreach (var empleado in lista)
            {
                if(empleado.NumEmpleado == numEmpleado)
                {
                    existe = true;

                    Console.Write("\n\tIntroduce el nombre:");
                    empleado.Nombre = Console.ReadLine();

                    Console.Write("\n\tIntroduce los apellidos:");
                    empleado.Apellidos = Console.ReadLine();

                    Console.Write("\n\tIntroduce el DNI:");
                    empleado.Dni = Console.ReadLine();

                    Console.Write("\n\tIntroduce la fecha de nacimiento:");
                    empleado.FechaNac = Console.ReadLine();

                    Console.Write("\n\tIntroduce la titulación:");
                    empleado.Titulacion = Console.ReadLine();

                    Console.Write("\n\tIntroduce el número de la seguridad social:");
                    int.TryParse(Console.ReadLine(), out int numSegSoc);
                    empleado.NumSegSoc = numSegSoc;

                    Console.Write("\n\tIntroduce el número de cuenta:");
                    int.TryParse(Console.ReadLine(), out int numCuenta);
                    empleado.NumCuenta = numCuenta;
                }
            }
            Console.Clear();
            if (existe)
                Console.WriteLine("\n\tEl empleado se modificó correctamente.");
            else
                Console.WriteLine("\n\tEl empleado no existe.");
        }

        public void Exportar(List<Empleado> lista)
        {
            StreamWriter sw = new StreamWriter("datos.txt");

            Console.WriteLine("\n\tSelecciona una opción:");
            Console.WriteLine("\t1. Exportar un empleado");
            Console.Write("\t2. Exportar todo");

            int opcion = Console.ReadKey(true).KeyChar - '0';

            while (opcion != 1 && opcion != 2)
            {
                Console.Write("\n\t[Error] Introduce un número válido.");
                opcion = Console.ReadKey(true).KeyChar - '0';
            }

            bool existe = false;
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.Write("\n\tIntroduce el número del empleado que quieres exportar:");
                    int.TryParse(Console.ReadLine(), out int numEmpleado);

                    foreach (var empleado in lista)
                    {
                        if (empleado.NumEmpleado == numEmpleado)
                        {
                            existe = true;
                            sw.WriteLine(empleado.ToString());
                            break;
                        }
                    }
                    break;
                case 2:
                    if (lista.Count != 0)
                    {
                        existe = true;
                        foreach (var empleado in lista)
                            sw.WriteLine(empleado.ToString());
                    }
                    break;
            }

            Console.Clear();
            if (existe)
                Console.WriteLine("\n\tLos datos se exportaron correctamente.");
            else
                Console.WriteLine("\n\tNo existen datos para exportar.");
            sw.Close();
        }
    }
}
