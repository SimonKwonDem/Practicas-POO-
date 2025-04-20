using CuentaBancaria.Semana5;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Cuenta cuentaMayor = new CuentaMayor("2233122", "Hernan", 5000, "habilitado", 20);
        cuentaMayor.MostrarInfo();
        cuentaMayor.IngresarMonto(2000);
        Console.WriteLine("");
        cuentaMayor.MostrarInfo();
        cuentaMayor.RetirarMonto(3000);
        Console.WriteLine("");
        cuentaMayor.MostrarInfo();*/
        Console.WriteLine("");

        Cuenta cuentaEstudiante = new CuentaEstudiante("f2323f", "Juan", 2000, "deshabilitado");
        cuentaEstudiante.MostrarInfo();
        Console.WriteLine("");
        cuentaEstudiante.IngresarMonto(2000);
        cuentaEstudiante.MostrarInfo();
        Console.WriteLine("");
        cuentaEstudiante.RetirarMonto(4000);
        cuentaEstudiante.MostrarInfo();

        Console.WriteLine("");
        Cuenta cuentaMenor = new CuentaMenor("dsad2231", "José", 1000, "habilitado");
        cuentaMenor.MostrarInfo();


    }
}