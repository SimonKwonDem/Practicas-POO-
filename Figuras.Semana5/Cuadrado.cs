using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Cuadrado : Figura 
    {
        private double lado;
        public double Lado 
        { get { return lado; } set { lado = value; } }
        public Cuadrado(double ladoCuadrado) 
        {
            this.lado = ladoCuadrado;
        }
        public override void CalcularArea()
        {
            area = (Lado * Lado);
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Cuadrado es: {area}");
        }
    }
}
