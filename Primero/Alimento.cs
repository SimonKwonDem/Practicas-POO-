using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoSemana5
{
    internal class Alimento : Producto
    {
        private int gramaje;
        public int Gramaje
        {
            get { return gramaje; }
            set { gramaje = value; }
        }

        public Alimento(int id, string nombre, string marca, int stock, double precio, int gramaje): base(id, nombre, marca, stock, precio)
        {
            this.gramaje = gramaje;
        }
        public override void DescontarStock(int cantidad)
        {
            if (cantidad <= Stock)
            {
                Stock -= cantidad;
                Console.WriteLine($"Nuevo stock: {Stock} unidades de {Nombre} ");
            }
            else Console.WriteLine($"La cantidad vendida supera el stock disponible. Stock disponible {Stock}");
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
