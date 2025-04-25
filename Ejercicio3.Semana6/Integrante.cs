using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Semana6
{
    internal class Integrante
    {
        public string nombre;
        public int edad;
        public int antiguedad;

        public Integrante(string nombre, int edad, int antiguedad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.antiguedad = antiguedad;
        }
        public void SumarAntiguedad(int cantidad)
        {
            if (cantidad > antiguedad)
            {
                this.antiguedad += cantidad;
            }
        }
        public void SumarAntiguedad(int cantidad, string motivo)
        {
            SumarAntiguedad(cantidad);
            Console.WriteLine("Actualización de antigüedad..");
            Console.WriteLine($"El motivo es: {motivo}");
            Console.WriteLine($"Antigüedad actualizada: {this.antiguedad}");
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Antigüedad: {antiguedad}");
        }
    }
}
