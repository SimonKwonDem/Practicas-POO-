using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Semana6
{
    internal class Jugador : Integrante
    {
        public string posicion;

        public Jugador(string nombre, int edad, int antiguedad, string posicion) : base(nombre, edad, antiguedad)
        {
            this.posicion = posicion;
        }
        
        public override void MostrarInfo()
        {
            Console.WriteLine($"Jugador");
            base.MostrarInfo();
            Console.WriteLine($"Posición Jugador: {posicion}");
        }
    }
}
