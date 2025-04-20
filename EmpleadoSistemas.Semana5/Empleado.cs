using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSistemas.Semana5
{
    internal class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private int dni;
        private double sueldo;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Dni { get { return dni; } set {  dni = value; } }
        public double Sueldo { get { return sueldo; } set { sueldo = value; } }

        public Empleado(int id, string nombre, string apellido, string telefono, string email, int dni, double sueldo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email; 
            this.dni = dni;
            this.sueldo = sueldo;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Id empleado: {Id}");
            Console.WriteLine($"Nombre empleado: {Nombre}");
            Console.WriteLine($"Apellido empleado: {Apellido}");
            Console.WriteLine($"Teléfono empleado: {Telefono}");
            Console.WriteLine($"Email empleado: {Email}");
            Console.WriteLine($"Dni empleado: {Dni}");
            Console.WriteLine($"Sueldo empleado: {Sueldo}");
        }
    }
}
