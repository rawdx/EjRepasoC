using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Repaso.Entidades
{
    internal class Empleado
    {
        int numEmpleado;
        string nombre;
        string apellidos;
        string dni;
        string fechaNac;
        string titulacion;
        int numSegSoc;
        int numCuenta;

        public Empleado(int numEmpleado, string nombre, string apellidos, string dni, string fechaNac, string titulacion, int numSegSoc, int numCuenta)
        {
            this.numEmpleado = numEmpleado;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNac = fechaNac;
            this.titulacion = titulacion;
            this.numSegSoc = numSegSoc;
            this.numCuenta = numCuenta;
        }

        public int NumEmpleado { get => numEmpleado; set => numEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Titulacion { get => titulacion; set => titulacion = value; }
        public int NumSegSoc { get => numSegSoc; set => numSegSoc = value; }
        public int NumCuenta { get => numCuenta; set => numCuenta = value; }

        public new string ToString()
        {
            return "Nº de empleado:" + numEmpleado + ";Nombre:" + nombre + ";Apellidos:" + apellidos + ";DNI:" + dni + ";Fecha de nacimiento:" + fechaNac + ";Titulación:" + titulacion + ";";
        }
    }
}
