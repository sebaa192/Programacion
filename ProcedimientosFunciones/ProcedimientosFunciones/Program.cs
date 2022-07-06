using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedimientosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = validacion("N1");
            int n2 = validacion("N2");
            int n3 = validacion("N3");

            int mayor = MenorMayor(n1, n2, n3, false);
            int menor = MenorMayor(n1, n2, n3, true);

            Console.WriteLine(mayor);
            Console.WriteLine(menor);
        }

        static int validacion(string txt)
        {
            int num;
            bool validar = false;
            Console.Clear();
            do
            {
                Console.WriteLine("Ingresar"+txt);
                validar = int.TryParse(Console.ReadLine(), out num);

                if (num < 0)
                {
                    validar = true;
                    Console.WriteLine("debe ser mayor que cero");

                }

            } while (!validar);
            return num;

        }

        static int MenorMayor(int n1, int n2, int n3, bool tipo)
        {
            int menor = 0;

            if (tipo)
            {


                if (n1 < n2 && n1 < n3)
                {
                    return n1;
                }
                else if (n2 < n1 && n2 < n3)
                {
                    return n2;
                }
                else
                {
                    return n3;
                }
            }
            else
            {

                if (n1 > n2 && n1 > n3)
                {
                    return n1;
                }
                else if (n2 > n1 && n2 > n3)
                {
                    return n2;
                }
                else
                {
                    return n3;

                }
            }
        }
        static void pares(int inicio,int fin)
        {
            for (int i = inicio; i < fin; i++)
            {


            }
        }
    }
}
