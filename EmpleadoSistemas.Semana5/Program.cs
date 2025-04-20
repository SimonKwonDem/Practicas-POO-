using EmpleadoSistemas.Semana5;

internal class Program
{
    private static void Main(string[] args)
    {
        DptoSistemas Desarrollo = new DptoSistemas("Desarrollo", true, true, 30);
        Empleado programador = new Programador(1, "Simon", "Kwon", "33221141", "Simon@prueba1.com", 43322211 , 100000 , "c#", "junior", 20, Desarrollo);
        programador.MostrarInfo();
    }
}