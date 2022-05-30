using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMethLab4
{
    internal static class Newton
    {
        private static double[] _nodes;

        private static double[,] _table;

        private static int FindDotsCount(int N)
        {
            return Math.Max(20 - N, N) - N % 3 - 3;
        }

        private static void FindNodes(int DotCount)
        {
            _nodes = new double[DotCount];
            for (int i = 0; i < DotCount; i++)
            {
                _nodes[i] = i;
            }
        }

        private static void InitTable(int DotCount)
        {
            _table = new double[DotCount,DotCount];
        }

        private static double Func(int N, double x)
        {
            double max = Math.Max(20 - N, N);
            return N * Math.Pow(x, max) + (N - 3) * Math.Pow(x, max - 2) + (N + 2) * Math.Pow(x, max - 3);
        }

        private static void FindFuncValues(int N)
        {
            for (int i = 0; i < _nodes.Length; i++)
            {
                _table[i,0] = Func(N, _nodes[i]);
            }
        }

        private static void FindSeparatedDifferences()
        {
            for (int i = 1; i < _table.GetLength(0); i++)
            {
                for (int j = 0; j < _table.GetLength(0) - i; j++)
                {
                    _table[j,i] = (_table[j + 1, i - 1] - _table[j, i - 1])
                            / (_nodes[j + i] - _nodes[j]);
                }
            }
        }

        private static double[] FindResultCoeffs()
        {
            double[] res = new double[_table.GetLength(0)];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = _table[0,i];
            }
            return res;
        }

        private static string GetPolynom(double[] coef)
        {
            string polynom = "L(x) = ";
            polynom += "(" + coef[0] + ")" + " + ";

            string temp = "";
            for (int i = 1; i < coef.Length; i++)
            {
                temp += "(x - " + _nodes[i - 1] + ")";
                polynom += "(" + coef[i] + ")*" + temp;
                if (i + 1 != coef.Length)
                {
                    polynom += " + ";
                }
            }
            return polynom;
        }

        public static void RunMethod(int N)
        {

            int DotCount = FindDotsCount(N);                

            FindNodes(DotCount);                            

            InitTable(DotCount);                          
                                                          

            FindFuncValues(N);                              

            FindSeparatedDifferences();                      
            DisplayResult.PrintTable(_table, _nodes);                  

            double[] coef;
            coef = FindResultCoeffs();                 
            string polynom = GetPolynom(coef);

            Console.WriteLine("Polynomial:");
            Console.WriteLine(polynom);                
        }
    }
}
