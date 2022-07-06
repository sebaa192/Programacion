using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglos
            //int[] numeros = new int[4];
            //int[,] num = new int[5,9];
            //Console.WriteLine(numeros[1]);
            //Console.WriteLine();

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero [0]",(i+1));
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine($"Numero:{numeros[i]}");

            //}
            //int mayor = 0;
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (mayor < numeros[i])
            //    {
            //        mayor = numeros[i];
            //    }

            //}

            // Console.WriteLine($"el numero mayor es : {mayor}");

            string [] ArreglosPer = new string[2];
            
            for (int i = 0; i < ArreglosPer.Length; i++)
            {
                Console.WriteLine("Ingrese un Nombre:");
                ArreglosPer[i] = Console.ReadLine();
            }
            for (int i = 0; i < ArreglosPer.Length; i++)
            {
                Console.WriteLine("El nombre en la posicion {0} es: {1}",i,ArreglosPer[i]);
            }
            for (int i = 0; i < ArreglosPer.Length; i++)
            {
                var nombres = ArreglosPer[i].Split(' ');
                
                Console.WriteLine("\n" + nombres[0].Remove(1).ToUpper() + nombres[0].Substring(1) + " " + nombres[1].Remove(1).ToUpper() + nombres[1].Substring(1));
                
            }
            for (int i = 0; i < ArreglosPer.Length; i++)
            {
                var c1 = ArreglosPer[i].Split(' ');

                Console.WriteLine("\n" + c1[0].Remove(1) + c1[1] + "@virginiogomez.cl");
                
            }
            Console.ReadKey();
        }
    }
}
