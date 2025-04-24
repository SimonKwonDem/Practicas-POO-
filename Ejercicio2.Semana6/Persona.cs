using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Semana6
{
    internal class Persona
    {
        public string nombre;
        private int edad;
        public int dni;

        public Persona()
        {
            Console.WriteLine("Constructor vacío.");
        }
        public Persona(string nombre, int edad)
        {
            Console.WriteLine("Constructor con dos parámetros");
            this.nombre = nombre;
            this.edad = edad;
            dni = 0;
        }
        public Persona(string nombre, int edad, int dni)
        {
            Console.WriteLine("Constructor con tres parámetros");
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"DNI: {dni}");
        }
    }
}