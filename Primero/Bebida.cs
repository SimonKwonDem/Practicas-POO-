using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoSemana5
{
    internal class Bebida : Producto
    {
        private int volumen;
        public int Volumen 
        {
            get {  return volumen; }
            set {  volumen = value; }
        }

        public Bebida(int id, string nombre, string marca, int stock, double precio, int volumen) : base(id, nombre, marca, stock, precio)
        {
            this.volumen = volumen;
        }
        public override void DescontarStock(int cantidad)
        {
            if (cantidad <= Stock)
            {
                Stock -= cantidad;
                Console.WriteLine($"Nuevo stock: {Stock} unidades de {Nombre}");
            }
            else Console.WriteLine($"La cantidad vendida supera el stock disponible. Stock disponible {Stock} unidades");
        }
        public override void AumentarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                Stock += cantidad;
            }
            Console.WriteLine($"Nuevo stock de {Nombre}: {Stock} unidades");
        }
    }
}
