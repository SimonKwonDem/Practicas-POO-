using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSistemas.Semana5
{
    internal class DptoSistemas
    {
        private string areaDeTrabajo;
        private bool poseeTitulo = false;
        private bool poseeCompuLaboral = false;
        private int cantGenteACargo;

        public string AreaDeTrabajo { get { return areaDeTrabajo; } set { areaDeTrabajo = value; } }
        public bool PoseeTitulo { get { return poseeTitulo; } set { poseeTitulo = value; } }
        public bool PoseeCompuLaboral { get { return poseeCompuLaboral; } set { poseeCompuLaboral = value; } }
        public int CantGenteACargo { get { return cantGenteACargo; } set { cantGenteACargo = value; } }

        public DptoSistemas(string areaDeTrabajo, bool poseeTitulo, bool poseeCompuLaboral, int cantGenteACargo)
        { 
            this.areaDeTrabajo = areaDeTrabajo;
            this.poseeTitulo = poseeTitulo;
            this.poseeCompuLaboral = poseeCompuLaboral;
            this.cantGenteACargo = cantGenteACargo;
        }
    }
}
