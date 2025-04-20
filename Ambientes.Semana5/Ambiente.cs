using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambientes.Semana5
{
    internal class Ambiente
    {
        private string sitema_Operativo;
        private int ram;
        private string base_Datos;
        private string app;

        public Ambiente(string sistema_Operativo, int ram, string base_Datos, string app) 
        {
            this.sitema_Operativo = sistema_Operativo;
            this.ram = ram;
            this.base_Datos = base_Datos;
            this.app = app;
        }
        public void VerificarDespliegue(string sist_Op, int ram, string bdd, string app)
        {
            if (this.sitema_Operativo == sist_Op &&
               this.ram == ram &&
               this.base_Datos == bdd &&
               this.app == app)
                Console.WriteLine("Es posible realizar el despliegue. (;");
            else 
                Console.WriteLine("No es posible realizar el despliegue. ):");
        }
    }
}
