using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Semana6
{
    internal class Auto : Vehiculo
    {
        public int cantPuertas;
        public bool esAutomatico;
        public Auto(string marca, string modelo, int anio, int cantPuertas, bool esAutomatico) : base(marca, modelo, anio)
        {
            this.cantPuertas = cantPuertas;
            this.esAutomatico = esAutomatico;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("Automóvil");
            base.MostrarInfo();
            Console.WriteLine($"Cantidad de puertas: {cantPuertas}");
            Console.WriteLine($"Es automático? {esAutomatico}");
        }
    }
}
