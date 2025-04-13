using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Semana4
{
    internal class Persona
    {
        /*Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

         Inicializar una clase Persona con atributos nombre, edad y dni.
         Crear un constructor sin parámetros que inicialice con valores por defecto.
         Inicializar la clase Persona con solo el nombre.
         Crear un constructor que reciba todos los atributos.
         Crear un método mostrarDatos() que imprima los atributos.

         Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).
         */
        public string nombre;
        public int dni;
        private int edad;

        public Persona()
        {

        }

    }
}
