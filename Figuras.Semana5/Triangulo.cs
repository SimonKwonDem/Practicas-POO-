using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Triangulo: Figura
    {
        private double baseT;
        private double alturaT;

        public double BaseT 
        { get { return baseT; } set { baseT = value; } }

        public double AlturaT
        { get { return alturaT; } set { alturaT = value; } }
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseT = baseTriangulo;
            this.alturaT = alturaTriangulo;
        }
        public override void CalcularArea()
        {
            area = (BaseT * AlturaT) / 2; 
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Triangulo es: {area}");
        }
    }
}
