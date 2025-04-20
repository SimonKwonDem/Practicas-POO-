using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria.Semana5
{
    internal class Cuenta
    {
        private string nro_Cuenta;
        private string nombre;
        private double saldo;
        private string estado_Cuenta;

        public string NCuenta 
        { get { return nro_Cuenta; } set { nro_Cuenta = value; } }
        public string Nombre
        {  get { return nombre; } set {nombre = value; } }
        public double Saldo
        { get { return saldo;} set { saldo = value; } }
        public string EstadoCuenta
        { get { return estado_Cuenta; } set { estado_Cuenta = value; } }

        public Cuenta(string nro_Cuenta, string nombre, double saldo, string estado_Cuenta)
        {
            this.nro_Cuenta = nro_Cuenta;
            this.nombre = nombre;
            this.saldo = saldo;
            this.estado_Cuenta = estado_Cuenta;
        }

        public virtual void IngresarMonto(int montoASumar)
        {
            if (montoASumar <= 0)
                Console.WriteLine("No es posible ingresar un monto negativo o igual a cero");
            else  
                saldo = saldo += montoASumar;
        }
        public virtual void RetirarMonto(int montoARestar)
        {
            if (montoARestar > Saldo)
                Console.WriteLine("Saldo Insuficiente");
            else 
                saldo = saldo -= montoARestar;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Cuenta: {nro_Cuenta}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Estado: {estado_Cuenta}");
        }
    }
}
