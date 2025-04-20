using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Semana5
{
    internal class Person
    {
        private int id;
        private string nombre;
        private int edad;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }

        public Person(int id, string nombre, int edad) 
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }

        public void CompararEdad(int edadAComparar)
        {
            if (this.edad == edadAComparar)
                Console.WriteLine($"Las edades son iguales.");
            else
                Console.WriteLine($"Las edades comparadas son distintas. {this.edad}, {edadAComparar}");
        }
    }
}
