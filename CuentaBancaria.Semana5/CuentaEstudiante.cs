using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria.Semana5
{
    internal class CuentaEstudiante : Cuenta
    {
        public CuentaEstudiante(string nro_Cuenta, string nombre, double saldo, string estado_Cuenta) : base(nro_Cuenta,nombre,saldo,estado_Cuenta)
        {
            Console.WriteLine("Cuenta de estudiante..");
        }
        // si es estudiante, se le da un bono del 20 % del monto ingresado..
        public override void IngresarMonto(int montoASumar)
        {
                Saldo += montoASumar * 0.2;
                base.IngresarMonto(montoASumar);   
        }
        public override void RetirarMonto(int montoARestar)
        {
            base.RetirarMonto(montoARestar);
        }
    }
}
