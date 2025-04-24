using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Semana6
{
    internal class Camioneta : Vehiculo
    {
        public int cantPuertas;
        public bool es4X4;

        public Camioneta(string marca, string modelo, int anio, int cantPuertas, bool es4X4) : base(marca, modelo, anio) 
        {
            this.cantPuertas = cantPuertas;
            this.es4X4 = es4X4;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Camioneta");
            base.MostrarInfo();
            Console.WriteLine($"La cantidad de puertas es: {cantPuertas}");
            Console.WriteLine($"es 4X4? {es4X4}");
        }
    }
}
