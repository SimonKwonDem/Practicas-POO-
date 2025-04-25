using Ejercicio3.Semana6;

internal class Program
{
    private static void Main(string[] args)
    {
        Integrante jugador1 = new Jugador("José", 22, 2, "delantero");
        jugador1.MostrarInfo();
        jugador1.SumarAntiguedad(3);
        jugador1.MostrarInfo();
        Console.WriteLine("");

        Integrante jugador2 = new Jugador("Hernán", 30, 6, "defensor");
        jugador2.MostrarInfo();
        jugador2.SumarAntiguedad(7, "buen rendimiento");
        Console.WriteLine("");

        Integrante tecnico1 = new Tecnico("Eduardo", 33, 4, "Ed Física");
        tecnico1.MostrarInfo();
        tecnico1.SumarAntiguedad(5);
        tecnico1.MostrarInfo();
        Console.WriteLine("");

        Integrante tecnico2 = new Tecnico("Gero", 23, 2, "Basket");
        tecnico2.MostrarInfo();
        tecnico2.SumarAntiguedad(3, "Falta de papeles");
    }
}