using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoSemana5
{
    internal class Supermercado
    {
        private List <Producto> productos;

        public Supermercado()
        {
            productos = new List <Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public void VenderProducto(Producto producto, int cantidad)
        {
            if (productos.Contains(producto))
            {
                producto.DescontarStock(cantidad);
            }
            else Console.WriteLine("El producto no existe");
        }

        public void AbastecerStock(Producto producto, int cantidad)
        {
            if (productos.Contains(producto))
            {
                producto.AumentarStock(cantidad);
            }
            else Console.WriteLine("No es posible aumentar el stock de un producto que no existe..");
        }
    }

}
