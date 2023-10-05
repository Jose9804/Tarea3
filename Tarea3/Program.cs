using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[8, 8];
            int contador = 0;
            int total = 0;
            for (int f = 3; f < 8; f++)
            {
                for (int c = 3; c < 8; c++)
                {
                    matriz[f, c] = contador++;
                    if (f == c)
                    {
                        total += matriz[f, c];
                    }
                    Console.Write("   " + matriz[f, c]);
                }

                Console.WriteLine();

            }

            Console.WriteLine("Sumatoria Total: {0}", total);
            Console.ReadLine();

        }
    }
}
