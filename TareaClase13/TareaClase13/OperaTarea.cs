using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase13
{
    static class OperaTarea
    {
       
        static public int Suma(int a, int b)
        {
            return a + b;
        }
        static public int Resta(int a, int b)
        {
            return a - b;
                 
        }
        static public int Multiplicacion(int a, int b)
        {
            return a * b;

        }
        static public int Division(int a, int b)
        {
            return a / b;

        }
        static public double PotenciaValorAlCuadrado1(int a)
        {
            double result = 0;

            result = Math.Pow(a, 2);

            return result;
        }
        static public double PotenciaValorAlCubo1(int a)
        {
            double result = 0;

            result = Math.Pow(a, 3);

            return result;
        }
        static public double PotenciaValorAlCuadrado2(int b)
        {
            double result = 0;

            result = Math.Pow(b, 2);

            return result;
        }
        static public double PotenciaValorAlCubo2(int b)
        {
            double result = 0;

            result = Math.Pow(b, 3);

            return result;
        }
        static public double Radio(double a)
        {
            
            double res = a / 2;

            return res;
        }

        static public double Area(double a)
         {
           
            double res = Math.Pow(a, 2) * Math.PI;

            return res;
        }
        static public double Perimetro(double a)
        {
            
            double res = (Math.PI * 2) * a;

            return res;
        }
    }
}
