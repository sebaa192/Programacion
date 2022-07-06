using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            //int numero = random.Next(10, 100);
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(10, 100);
            }

            ImprimeVector(vector);
            Console.WriteLine();
            Console.WriteLine("El numero mayor: " + vector.Max());
            Console.WriteLine();
            Console.WriteLine("El numero menor: " + vector.Min());
            Console.WriteLine();
            Console.WriteLine("La suma del vector es: " + vector.Sum());
            Console.WriteLine();
            Console.WriteLine("El promedio es: " + vector.Average());
            //ordenar por funciones

            //Array.Sort(vector);
            //ImprimeVector(vector);
            //Console.WriteLine();
            //vector = vector.Reverse().ToArray();
            //ImprimeVector(vector);

            //Ordenar por linq:pueden consultar a cada uno de los objetos que contiene info.
            int [] vectorNuevo = vector.Where(x => x > 50).ToArray();
            ImprimeVector(vectorNuevo);
            Console.WriteLine();
            //vector.OrderByDescending(x => x).ToArray();
            int[] vectorPares = vector.Where(x => x % 2 == 0).ToArray();
            ImprimeVector(vectorPares);
            Console.WriteLine();
            int [] ordenVector = vector.OrderByDescending(x => x).ToArray();
            ImprimeVector(ordenVector);
            Console.ReadKey();
        }
               
        static int BuscaMayor(int[] vector)
        {
            int mayor = 0;

            for (int i = 0; i < vector.Length; i++)
            {

                if (vector[i]>mayor)
                {
                    mayor = vector[i];
                }

            }
            return mayor;
        }

        static int BuscaMenor(int[] vector)
        {
            int menor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {

                if (vector[i] < menor)
                {
                    menor = vector[i];
                }

            }
            return menor;
        }

        static int SumaVector(int[] vector)
        {
            int suma =0;

            for (int i = 1; i < vector.Length; i++)
            {

                suma = suma + vector[i]; 

            }
            return suma;
        }

        static void ImprimeVector(int[] vector)
        {
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                
                    Console.Write(vector[i] + " ");
               ;
            }
        }
    }
}
