using SupermercadoSemana5;

internal class Program
{
    private static void Main(string[] args)
    {
        Supermercado supermercado = new Supermercado();
        Bebida gaseosa = new Bebida(1, "Coca-cola", "Coca-cola", 20, 100, 125);
        Bebida agua = new Bebida(2, "agua mineral", "Glaciar", 10, 21.5, 250);
        supermercado.AgregarProducto(gaseosa);
        supermercado.VenderProducto(gaseosa, 10); // Se ejecuta el descuento de stock correctamente.
        supermercado.VenderProducto(gaseosa,25); // supera las unidades que hay en stock.
        supermercado.VenderProducto(agua, 5); // este producto no se agrego a la lista de productos del supermercado..
        Alimento pan = new Alimento(3, "pan lactal", "fargo", 15, 250, 125);
        supermercado.AgregarProducto(pan);
        supermercado.VenderProducto(pan, 7);
        supermercado.AbastecerStock(pan, 2);
    }
}