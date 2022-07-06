using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = 10;
            //aumentar(ref numero);// ref apunta al espacio de memoria

            //Console.WriteLine(numero);
            //int x = cambio(numero);

            //Console.WriteLine(x);//salida de x

            int v1 = 10;
            int v2 = 30;
            //secuencia(v1); 
            Operaciones op = new Operaciones();
            int resultado = op.suma(v1, v2);

            int resultadoResta = op.resta(v1, v2);
            Console.WriteLine(resultado);
            Console.WriteLine(resultadoResta);
            //crear clases de operaciones que permita lo siguiente:
            //Ideal ocupar pasos por referencia y variables.

                //suma
                //resta
                //division
                //multiplicacion 
                //exponencial
                //calcular area
                //calculo de perimetro
                //calculo de radio
            Console.ReadKey();
        }
        static void aumentar(ref int numero)//paso por el byval - por referencia ref
        {
            numero = numero + 1;
        }
        static int cambio(int numero, int cambio=0)//asignacion por defecto
        {
            return cambio;

        }
        static void secuencia(int valor)//metodo de recursivo
        {
            Console.WriteLine(valor);
            if (valor == 100)
             return;
            else
            {
                valor = valor + 1;
                secuencia(valor);//recursividad de metodo
            }
        }

    }
}
