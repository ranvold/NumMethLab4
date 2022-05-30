using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMethLab4
{
    internal class DisplayResult
    {

        public static void PrintColumn(double[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(i + ":\t");
                Console.Write("{0:F3}", m[i]);
                Console.WriteLine();
            }
        }

        public static void PrintTable(double[,] table, double[] nodes)
        {
            Console.WriteLine("Separated differences table:");
            Console.WriteLine("x");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.Write("{0:F1}", nodes[i]);
                Console.Write("\t");
                for (int j = 0; j < table.GetLength(0) - i; j++)
                {

                    Console.Write("{0:F3}", table[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
