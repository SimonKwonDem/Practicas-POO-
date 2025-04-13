using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Semana4
{
    internal class Calculadora
    {
        /*Crear una clase Calculadora.

        Crear un método sumar(int a, int b) que devuelva una suma.
        Crear un método sumar(double a, double b, double c) para sumar tres números.
        Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
        Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).    
         */

        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public double SumarDecimal(double a, double b, double c)
        {
            return a + b + c;
        }
        public void MensajeSuma(string mensaje, int a, int b)
        {
            Console.WriteLine($"{mensaje}, {Sumar(a, b)}");
        }
        public bool ParImpar(int a)
        {
            if(a % 2 == 0)
            {
                return true;
            }else return false; 
        }
    }
}
