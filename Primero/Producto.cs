using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoSemana5
{
    internal class Producto
    {
        private int id;
        private string nombre;
        private string marca;
        private int stock;
        private double precio;

        public int Id 
        { get {return id; }  set { id = value; } }
        public string Nombre
        { get { return nombre; } set { nombre = value; } }
        public string Marca
        { get { return marca; } set {  marca = value; } }
        public int Stock
        { get { return stock; } set { stock = value; } }
        public double Precio
        { get { return precio; } set { precio = value; } }

        public Producto(int id, string nombre, string marca, int stock, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.marca = marca;
            this.stock = stock;
            this.precio = precio;
        }
        public virtual void DescontarStock(int cantidad)
        {
            if (cantidad <= Stock)
            {
                Stock -= cantidad;
                Console.WriteLine($"Nuevo stock: {Stock}");
            }
            else Console.WriteLine("La cantidad vendida supera el stock disponible.");
        }
        public virtual void AumentarStock(int cantidad)
        {
            if(cantidad > 0)
            {
                Stock += cantidad;  
            }
        }
    }
}
