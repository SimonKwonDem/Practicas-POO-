using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Semana7
{
    internal class Persona
    {
        public string nombre;
        public string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;  
        }

        public virtual void Presentarse()
        {
            Console.Write($"Hola, mi nombre es {nombre}");
        }
    }
}
