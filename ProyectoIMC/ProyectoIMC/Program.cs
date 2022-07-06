using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc1 = 0;
            int user = 0;
            double imcmejor = 0;
            double imcmalo = 0;
            Console.WriteLine("-------------------------------------");
            Console.Write("INGRESE LA CANTIDAD DE PERSONAS: ");
            int can = int.Parse(Console.ReadLine());
            string[] nombre = new string[can];
            double[] peso = new double[can];
            double[] altura = new double[can];
            double[] im = new double[can];
            Console.WriteLine("-------------------------------------");
            Console.Clear();
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("INGRESE NOMBRE: ");
                nombre[i] = Console.ReadLine();
                peso[i] = valida("PESO");
                altura[i] = valida("ALTURA");
                Console.WriteLine("-------------------------------------");
                im[i] = imc(peso[i], altura[i]);
                imcmejor = imc(peso[i], altura[i]);
                imcmalo = imc(peso[i], altura[i]);
                if (imc1 < imcmalo)
                {
                    imc1 = imcmalo;
                    user = i;
                }

                Console.Clear();
            }
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("NOMBRE:   " + nombre[i]);
                Console.WriteLine("PESO  :   " + peso[i]);
                Console.WriteLine("ALTURA:   " + altura[i]);
                Console.Write("IMC   :" + imc(peso[i], altura[i]));
                if (im[i] < 30)
                {
                    Console.WriteLine(" Imc bueno");
                }
                else
                {
                    Console.WriteLine(" Imc malo");
                }
            }
            for (int i = 0; i < can; i++)
            {
                if (i == user)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("USUARIO CON IMC MAS ALTO");
                    Console.WriteLine("NOMBRE:   " + nombre[i]);
                    Console.WriteLine("PESO  :   " + peso[i]);
                    Console.WriteLine("ALTURA:   " + altura[i]);
                    Console.Write("IMC   :" + imc(peso[i], altura[i]));
                }
            }
            Console.ReadKey();
        }
        static Double valida(string txt)
        {
            double num;
            bool val = false;
            do
            {
                Console.WriteLine("INGRESE {0}", txt);
                val = double.TryParse(Console.ReadLine().Replace('.', ','), out num);
                if (num < 0)
                {
                    val = false;
                    Console.WriteLine("ingrese un {0} correcto", txt);
                }

            } while (!val);
            return num;
        }

        static double imc(double x, double y)
        {
            return x / (y * y);
        }
    }
}
