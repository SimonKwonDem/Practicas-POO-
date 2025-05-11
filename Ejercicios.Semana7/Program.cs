using Ejercicios.Semana7;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Crear una clase padre Persona con el método presentarse() que imprima por consola "Hola, mi nombre es {nombre atributo}".
         Luego crear la clase hija Alumno y sobreescribir la clase padre Persona haciendo que ejecuta su funcionalidad inicial
         y agregar extra "y soy alumno del instituo {instituto atributo}"*/

        Persona p1 = new Persona("Simón", "Kwon", 21);
        p1.Presentarse();
        Console.WriteLine("");
        Alumno a1 = new Alumno("José", "José", 26, "UTN");
        a1.Presentarse();
    }
}