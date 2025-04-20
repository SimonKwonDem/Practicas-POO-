using Figuras.Semana5;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>
        {
            new Triangulo(10, 5),
            new Cuadrado(6),
            new Circulo(3)
        };

        foreach (Figura figura in figuras)
        {
            figura.CalcularArea();
            figura.MostrarArea();
        }
    }
}