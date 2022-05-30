using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMethLab4
{
    internal class Spline
    {
        private static double[] _result = new double[5];

        private static double Func(int x)
        {
            return 2 * Math.Pow(x, 8) + 3 * Math.Pow(x, 5) - 3 * Math.Pow(x, 3) + 1;
        }

        public static void RunMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                _result[i] = Func(i);
            }
            DisplayResult.PrintColumn(_result);
        }
    }
}
