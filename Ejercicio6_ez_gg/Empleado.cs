using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace Ejercicio6_ez_gg
{
    class Empleado:Persona, IComparable<Empleado>
    {
        public string cargo, fecha_De_ingreso, departamento, No_carnet;
        public double sueldo;

        //Metodo que ordenara los sueldos de los empleados, agarrando registro de dos en dos para la comparacion. 
        //retorna -1,0,1
        public int CompareTo( Empleado other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.sueldo.CompareTo(other.sueldo);
        }
        //Polimorfismo, sobreescribir el metodo ToString para que imprima la lista.
        public override string ToString()
        {
            return
                ".:.Nombre: " + Nombres + "\n" +
                ".:.Apellido: " + apellidos + "\n" +
                ".:.Sexo: " + sexo + "\n" +
                ".:.Fecha de Nacimiento: " + fecha_nacimiento + "\n" +
                ".:.Dui: " + dui + "\n" +
                ".:.Telefono: " + telefono + "\n" +
                ".:.Cargo: " + cargo + "\n" +
                ".:.Fecha de Ingreso: " + fecha_De_ingreso + "\n" +
                ".:.Departamento: " + departamento + "\n" +
                ".:.Nº de carnet: " + No_carnet + "\n" +
                ".:.Sueldo: " + sueldo + "\n";
        } 
    }
}