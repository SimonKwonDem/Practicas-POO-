using Ejercicios.Semana4;

internal class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.MostrarDatos();
        Console.WriteLine();

        Persona persona2 = new Persona("Simon");
        persona2.MostrarDatos();
        Console.WriteLine();

        Persona persona3 = new Persona("Juan", 45122333, 21);
        persona3.MostrarDatos();
        Console.WriteLine();

        //Al método get le sumo la edad que quiero que se incremente en edad.
        Console.WriteLine($"Pasaron unos años... la edad es: {persona3.GetEdad() + 3}");
        Console.WriteLine();

        //Modifico la edad a través del método set.
        persona3.SetEdad(24);
        persona3.MostrarDatos();

        Calculadora calculadora1 = new Calculadora();
        Console.WriteLine();
        
        Console.WriteLine($"{calculadora1.Sumar(23, 12)}");
        Console.WriteLine();

        Console.WriteLine($"{calculadora1.SumarDecimal(24.5, 22.32, 11.2)}");
        Console.WriteLine();

        calculadora1.MensajeSuma("Resultado de la suma:", 23, 23);
        Console.WriteLine();
        
        Console.WriteLine($"{calculadora1.ParImpar(10)}");
        Console.WriteLine();

        Console.WriteLine($"{calculadora1.ParImpar(7)}");
    }

}