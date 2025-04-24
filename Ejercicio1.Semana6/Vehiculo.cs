using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Semana6
{
    internal class Vehiculo
    {
        private string marca;
        private string modelo;
        private int anio;
        public string Marca { get { return marca; } }
        public string Modelo { get { return modelo; } }
        public int Anio { get { return anio; } }

        public Vehiculo(string marca, string modelo, int anio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        public void CambiarMarcha()
        {
            Console.WriteLine("Cambiando marcha...");
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Anño: {Anio}");
        }
    }
}
