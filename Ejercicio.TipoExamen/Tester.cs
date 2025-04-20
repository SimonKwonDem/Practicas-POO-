using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.TipoExamen
{
    internal class Tester : Persona
    {
        private string tipoTest;
        private int cantProyectos;

        public string TipoTest { get { return tipoTest; } set { tipoTest = value; } }
        public int CantProyectos { get { return cantProyectos; } set { cantProyectos = value; } }

        public Tester(string nombre, string apellido, int edad, string tipoTest, int cantProyectos) : base(nombre, apellido, edad)
        {
            this.tipoTest = tipoTest;
            this.cantProyectos = cantProyectos;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Tester.");
            base.MostrarInfo();
            Console.WriteLine($"El tipo de test que utiliza es {TipoTest}");
            Console.WriteLine($"La cantidad de proyectos asignados es: {CantProyectos}");
        }
    }
}
