using Ejercicio_Repaso.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso.Servicios
{
    internal interface InterfazEmpleado
    {
        void RegistrarEmpleado(List<Empleado> lista);
        void ModificarEmpleado(List<Empleado> lista);
        void Exportar(List<Empleado> lista);
    }
}
