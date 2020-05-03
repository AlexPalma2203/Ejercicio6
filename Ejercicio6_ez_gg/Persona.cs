using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ejercicio6_ez_gg
{
    class Persona : IEquatable<Persona>
    {
        public string Nombres, apellidos, sexo,fecha_nacimiento , telefono;
        public int dui;

        //Modificacion del Equeals para que no compare por objeto
        public override bool Equals(object/*clase base*/ other)
        {
            if (other == null) {
                return false;
            }
            if (!(other is Persona persona))
            {
                return false;
            }

            return Equals(persona);
        }

        //Funcion hash para dui
        public override int GetHashCode()
        {
            return dui;
        }

        //Metodo que hace una busquedad para dui, y ocuparlo en el override
        public bool Equals(Persona other)
        {
            if (other == null) return false;
            return (this.dui.Equals(other.dui));
        }
    }
}