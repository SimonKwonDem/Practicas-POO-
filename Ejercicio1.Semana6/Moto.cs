using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Semana6
{
    internal class Moto : Vehiculo
    {
        public string tipoManubrio;

        public Moto(string marca, string modelo, int anio, string tipoManubrio) : base(marca, modelo, anio)
        {
            this.tipoManubrio = tipoManubrio;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Motocicleta");
            base.MostrarInfo();
            Console.WriteLine($"Tipo de Manubrio: {tipoManubrio}");
        }
    }
}
