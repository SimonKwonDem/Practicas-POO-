using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria.Semana5
{
    internal class CuentaMayor : Cuenta
    {
        private int edad;
        public int Edad
        { get { return edad; } set { edad = value; } }

        public CuentaMayor(string nro_Cuenta, string nombre, double saldo, string estado_Cuenta, int edad) : base(nro_Cuenta, nombre, saldo, estado_Cuenta)
        {
            this.edad = edad;
        }

        public override void IngresarMonto(int montoASumar)
        {
            if (edad > 18)
                base.IngresarMonto(montoASumar);
            else
                Console.WriteLine("No es posible realizar la transacción. Debe ser mayor de edad(18 años).");
        }

        public override void RetirarMonto(int montoARestar)
        {
            if (edad > 18)
                base.RetirarMonto(montoARestar);
            else
                Console.WriteLine("No es posible realizar la transacción. Debe ser mayor de edad(18 años)");
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"La edad es de: {edad} años");
        }
    }
}
