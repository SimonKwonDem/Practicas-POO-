using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Circulo : Figura
    {
        private double radio;
        public double Radio 
        { get { return radio; } set { radio = value; } }
        public Circulo(double radioCirculo)
        {
            this.radio = radioCirculo;
        }
        public override void CalcularArea()
        {
            area = Math.PI * (Radio * Radio);
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Circulo es: {area}");
        }
    }
}
