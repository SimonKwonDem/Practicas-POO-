using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.TipoExamen
{
    internal class Gestion
    {
        private List<Persona> integrantes = new List<Persona>();

        public void AgregarIngtegrante(Persona persona)
        {
            integrantes.Add(persona);
        }

        public void MostrarIntegrantes()
        {
            foreach(Persona persona in integrantes)
            {
                persona.MostrarInfo();
                Console.WriteLine("");
            }
        }
    }
}
