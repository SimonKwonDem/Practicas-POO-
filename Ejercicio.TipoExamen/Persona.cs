using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.TipoExamen
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}
