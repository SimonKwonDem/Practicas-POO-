using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal abstract class Figura
    {
        protected double area;
        public virtual void MostrarArea()
        {
            if (area < 0)
                Console.WriteLine($"El área no se ha calculado");
            else
                Console.WriteLine($"El área es: {area}");
        }
        public abstract void CalcularArea();



    }
}
