using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.TipoExamen
{
    internal class Desarrollador : Persona
    {
        private string seniority;
        private string lenguajeSistemas;
        public string Seniority { get { return seniority; } set { seniority = value; } }
        public string LenguajeSistemas { get { return lenguajeSistemas; } set { lenguajeSistemas = value; } }

        public Desarrollador(string nombre, string apellido, int edad, string seniority, string lenguajeSistemas) : base(nombre, apellido, edad)
        {
            this.seniority = seniority;
            this.lenguajeSistemas = lenguajeSistemas;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Desarrollador.");
            base.MostrarInfo();
            Console.WriteLine($"Seniority: {Seniority}");
            Console.WriteLine($"Lenguaje dominante {LenguajeSistemas}");
        }
    }
}
