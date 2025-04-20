using Persona.Semana5;
    
internal class Program
{
    private static void Main(string[] args)
    {
        Person persona1 = new Person(1,"Simon", 21);
        Person persona2 = new Person(2, "Juan", 22);
        Person persona3 = new Person(3, "José", 22);
        persona2.CompararEdad(persona1.Edad);
        persona3.CompararEdad(persona2.Edad);
    }
}


