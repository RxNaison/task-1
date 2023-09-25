using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace megasuperapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 4];

            Rand();

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Количество нулей в массиве: " + count);

            void Rand()
            {
                Random rand = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rand.Next(0, 3);
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }


    }
}
