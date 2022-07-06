using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[7, 7];
            int inicio = 0;
            int size = matriz.GetLength(1);
            Console.WriteLine("****Matriz 1****");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {

                        matriz[i, j] = ++inicio;

                    }
                    else
                    {
                        matriz[i, j] = inicio--;

                    }

                }
                inicio = inicio + size;
            }
            ImprimeMatriz(matriz);
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("**** Matriz 2 ****");

            int aux = 0;

            int aux2 = matriz.GetLength(1)-1;
            
            int contador = 1;

            while (contador <= matriz.GetLength(0) * matriz.GetLength(1))
            {
               

                for (int i = aux; i <= aux2; i++)
                {
                    for (int j = aux; j <= aux2; j++)
                    {
                        if (i == aux)
                        {
                            matriz[i, j] = contador++;
                        }
                        else
                        {
                            if (j == aux2)
                            {
                                matriz[i, j] = contador++;
                            }

                        }
                    }

                }

                for (int i = aux2 ; i >= aux+1; i--)
                {
                    for (int j = aux2 - 1; j >= aux  ; j--)
                    {
                        if (i == aux2)
                        {
                            matriz[i, j] = contador++;
                        }
                        else
                        {
                            if (j == aux)
                            {
                                matriz[i, j] = contador++;
                            }

                        }
                    }

                }
                aux++;
                aux2--;
            }
       
           

            ImprimeMatriz(matriz);
            
            Console.ReadKey();
        }
        static void ImprimeMatriz(int [,]matriz )
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " \t ");
                }
                Console.WriteLine("  ");
            }
        }
    }
}
