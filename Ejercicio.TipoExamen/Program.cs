using Ejercicio.TipoExamen;

internal class Program
{
    private static void Main(string[] args)
    {
       Gestion gestion = new Gestion();
        Desarrollador dev1 = new Desarrollador("Tommi", "Perez", 21, "Senior", "Java");
        Console.WriteLine("");

        Desarrollador dev2 = new Desarrollador("Cinthia", "Sanchez", 19, "Senior", "Angular");
        Console.WriteLine("");
        
        Tester tester1 = new Tester("Walter", "Lopez", 25, "Manual", 7);
        Console.WriteLine("");
        
        Tester tester2 = new Tester("Ezequiel", "Gomez", 25, "Automatico", 8);

        gestion.AgregarIngtegrante(dev1);
        gestion.AgregarIngtegrante(dev2);
        gestion.AgregarIngtegrante(tester1);
        gestion.AgregarIngtegrante(tester2);
        gestion.MostrarIntegrantes();

    }
}