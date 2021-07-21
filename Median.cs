using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    class Median
    {
        private static double[] median;

        public Median() 
        {
            median = Array.Empty<double>();
        }

        public static double[] Input(int[] x)
        {   
            for(int i = 0; i <= x.Length; i++)
            {
                median[i] = x[i];
            }
            return new[] { 15.5, 16.7 };
        }
    }
}
