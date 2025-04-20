using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria.Semana5
{
    internal class CuentaMenor : Cuenta
    {
        public CuentaMenor(string nro_Cuenta, string nombre, double saldo, string estado_Cuenta) : base(nro_Cuenta, nombre, saldo, estado_Cuenta)
        {
            Console.WriteLine("Cuenta de menor de edad...");
        }
        public override void IngresarMonto(int montoASumar)
        {
            base.IngresarMonto(montoASumar);
        }
        public override void RetirarMonto(int montoARestar)
        {
            base.RetirarMonto(montoARestar);
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
        }
    }
}
