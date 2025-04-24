using Ejercicio1.Semana6;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehiculo auto = new Auto("peugeot", "206", 2018, 4, true);
        auto.MostrarInfo();
        Console.WriteLine("");
        Vehiculo moto = new Moto("honda", "skua", 2015, "curvado");
        moto.MostrarInfo();
        Console.WriteLine("");
        Vehiculo camioneta = new Camioneta("volkswagen", "amarok", 2022, 4, true);
        camioneta.MostrarInfo();
    }
}