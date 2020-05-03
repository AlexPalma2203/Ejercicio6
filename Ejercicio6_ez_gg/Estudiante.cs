using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ejercicio6_ez_gg
{
    class Estudiante:Persona , IComparable<Estudiante> 
    {
        public string Num_carnet, nivel_de_estudios, nombre_de_la_universidad, carrera;
        public int Materias_inscritas;
        public double notas, CUM;
        public override string ToString/*clase base*/ ()
        {
            return
                ".:.Nombre: " + Nombres + "\n" +
                ".:.Apellido: " + apellidos + "\n" +
                ".:.Sexo: " + sexo + "\n" +
                ".:.Fecha de Nacimiento: " + fecha_nacimiento + "\n" +
                ".:.Dui: " + dui + "\n" +
                ".:.Telefono: " + telefono + "\n" +
                ".:.Carnet: " + Num_carnet + "\n" +
                ".:.Nivel de Estudios: " + nivel_de_estudios + "\n" +
                ".:.Nombre de Universidad: " + nombre_de_la_universidad + "\n" +
                ".:.Carrera: " + carrera + "\n" +
                ".:.Materias Inscritas: " + Materias_inscritas + "\n" +
                ".:.Notas: " + notas + "\n" +
                ".:.Cum: " + CUM + "\n";
        }
        //Metodo que ordenara los Cum de los estudiantes ordenados, agarrando registro de dos en dos para la comparacion. 
        //retorna -1,0,1
        public int CompareTo( Estudiante other)
        {
            if (other == null)
            {
                return 1;
            }
            if (this.CUM ==other.CUM) {
                return 0;
            }
            else if (this.CUM > other.CUM ) {
                return 1;
            }
            else{
                return -1;
            }
            //return this.CUM.CompareTo(other.CUM);
        }
    }
}