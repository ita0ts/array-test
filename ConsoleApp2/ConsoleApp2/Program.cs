using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[6 , 6];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 1;
                    matriz[j, i] = 0;
                }
                matriz[i, i] = 2;
                

            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                { 

                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }

    }
