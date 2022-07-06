using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase13
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear clases de operaciones que permita lo siguiente:
            //Ideal ocupar pasos por referencia y variables.

            //suma
            //resta
            //division
            //multiplicacion 
            //exponencial

            //PARA MAÑANA !!!!

            //calcular area (Jugar con datos nuevos)
            //calculo de perimetro (Jugar con datos nuevos)
            //calculo de radio (Jugar con datos nuevos)
            int num1 = IngresaValores("N1");
            int num2 = IngresaValores("N2");

            int ResultSuma = OperaTarea.Suma(num1, num2);
            Console.WriteLine("resultado de la suma : " + ResultSuma);


            int ResultResta = OperaTarea.Resta(num1, num2);
            Console.WriteLine("resultado de la resta: " + ResultResta);

            int ResultMultiplicacion = OperaTarea.Multiplicacion(num1, num2);
            Console.WriteLine("resultado de la Multiplicacion: " + ResultMultiplicacion);

            int ResultDivision = OperaTarea.Division(num1, num2);
            Console.WriteLine("resultado de la Division: " + ResultDivision);

            double ResultPotecia = OperaTarea.PotenciaValorAlCuadrado1(num1);
            Console.WriteLine("Resultado potencia al Cuadrado valor 1 es :" + ResultPotecia);

            double ResultPoteciaC1 = OperaTarea.PotenciaValorAlCubo1(num1);
            Console.WriteLine("Resultado potencia al Cubo valor 1 es :" + ResultPoteciaC1);

            double ResultPotecia2 = OperaTarea.PotenciaValorAlCuadrado2(num2);
            Console.WriteLine("Resultado potencia al Cuadrado valor 2 es :" + ResultPotecia2);

            double ResultPoteciaC2 = OperaTarea.PotenciaValorAlCubo2(num2);
            Console.WriteLine("Resultado potencia al Cubo valor 2 es :" + ResultPoteciaC2);

            Console.ReadLine();
            Console.Clear();

            double NumArea = IngresaValoresArea("Diametro de un circulo");

            double resultadoRadio = OperaTarea.Radio(NumArea);
            Console.WriteLine("Resultado del radio : " + resultadoRadio);

            double ResultadoArea = OperaTarea.Area(NumArea);
            Console.WriteLine("Resultado del Area :" + ResultadoArea);

            double ResultadoPerimetro = OperaTarea.Perimetro(NumArea);
            Console.WriteLine("Resultado del Perimetro :" + ResultadoPerimetro);

            Console.WriteLine("FIN DEL PROGRAMA");

            
            Console.ReadKey();

        }

        static int IngresaValores(string txt)
        {
            int num;
            bool validar = false;
            do
            {
                Console.WriteLine("Ingresar numero {0}:",txt);
                validar = int.TryParse(Console.ReadLine(), out num);

              

            } while (!validar || num < 0 );
            return num;

        }
         static double IngresaValoresArea(string txt)
        {
            double num;
            bool validar = false;
            do
            {
                Console.WriteLine("Ingresar numero {0}:",txt);
                validar = double.TryParse(Console.ReadLine(), out num);

              

            } while (!validar || num < 0 );
            return num;

        }
    }
}
