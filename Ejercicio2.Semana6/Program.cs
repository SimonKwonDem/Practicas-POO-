using Ejercicio2.Semana6;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona p1 = new Persona();
        p1.MostrarInfo();
        Console.WriteLine("");
        Persona p2 = new Persona("Simon", 21);
        p2.MostrarInfo();
        Console.WriteLine("");
        Persona p3 = new Persona("Juan", 22, 33111222);
        p3.MostrarInfo();
    }
}