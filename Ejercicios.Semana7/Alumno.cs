using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Semana7
{
    internal class Alumno : Persona
    {
        public string instituto;

        public Alumno(string nombre, string apellido, int edad, string instituto ) : base(nombre, apellido, edad)
        {
            this.instituto = instituto;
        }
        public override void Presentarse()
        {
            base.Presentarse();
            Console.WriteLine(($" y soy del instituto {instituto}"));
        }
    }
}
