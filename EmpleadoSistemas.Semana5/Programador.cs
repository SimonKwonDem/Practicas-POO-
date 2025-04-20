using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSistemas.Semana5
{
    internal class Programador : Empleado
    {
        private string lenguajeSistemas;
        private string seniority;
        private int cantTumboProdu;
        private DptoSistemas dptoSistemas;

        public string LenguajeSist { get { return lenguajeSistemas; } set { lenguajeSistemas = value; } }
        public string Seniority { get { return seniority; } set {  seniority = value; } }
        public int CantTumboProdu { get { return cantTumboProdu; } set { cantTumboProdu = value; } }
        public DptoSistemas DptoSistemas { get { return dptoSistemas; } set { dptoSistemas = value; } }

        public Programador(int id, string nombre, string apellido, string telefono, string email, int dni, double sueldo, string lenguajeSistemas, string seniority, int cantTumboProdu, DptoSistemas dptoSistemas) : base(id, nombre, apellido, telefono, email, dni, sueldo)
        { 
            this.lenguajeSistemas = lenguajeSistemas;
            this.seniority = seniority;
            this.cantTumboProdu = cantTumboProdu;
            this.dptoSistemas = dptoSistemas;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("Información Programador:");
            base.MostrarInfo();
            Console.WriteLine($"Lenguaje utilizado: {LenguajeSist}");
            Console.WriteLine($"Seniority: {Seniority}");
            Console.WriteLine($"Este programador tumbó producción {CantTumboProdu} veces.");
            Console.WriteLine($"Pertenece al departamento de {DptoSistemas.AreaDeTrabajo}");
        }
    }
}
