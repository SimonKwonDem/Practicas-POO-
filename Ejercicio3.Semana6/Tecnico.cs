using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Semana6
{
    internal class Tecnico : Integrante
    {
        private string especialidad;
        public string Especialidad { get { return especialidad; } }

        public Tecnico(string nombre, int edad, int antiguedad, string especialidad) : base(nombre, edad, antiguedad)
        {
            this.especialidad = especialidad;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Técnico");
            base.MostrarInfo();
            Console.WriteLine($"Especialidad: {especialidad}");
        }
    }
}
