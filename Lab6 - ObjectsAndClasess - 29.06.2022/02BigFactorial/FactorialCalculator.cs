using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02BigFactorial
{
    internal class FactorialCalculator
    { 
        public int N { get; set; }

        public FactorialCalculator(int n)
        {
            N = n;
        }

        public BigInteger Calculate() 
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

              return factorial;

        }
    }
}
