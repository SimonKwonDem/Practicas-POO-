using Ambientes.Semana5;

internal class Program
{
    private static void Main(string[] args)
    {
        Ambiente Desarrollo = new Ambiente("linux", 4, "postgresql", "openjdk");
        Ambiente Testing = new Ambiente("windows", 4, "mysql", "dotnet");
        Ambiente PreProducción = new Ambiente("linux", 8, "mysql", "openjdk");
        Ambiente Producción = new Ambiente("linux", 4, "postgresql", "openjdk"); 

        // Requerido para realizar el despliegue...
        string sistOp = "linux";
        int ram = 4;
        string bDD = "postgresql";
        string aPP = "openjdk"; 

        Desarrollo.VerificarDespliegue(sistOp, ram, bDD, aPP);
        Console.WriteLine("");
        Testing.VerificarDespliegue(sistOp, ram, bDD, aPP);
        Console.WriteLine("");
        PreProducción.VerificarDespliegue(sistOp, ram, bDD, aPP);
        Console.WriteLine("");
        Producción.VerificarDespliegue(sistOp, ram, bDD, aPP);
    }
}