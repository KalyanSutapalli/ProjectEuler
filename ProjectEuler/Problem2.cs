using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        private long evenSum;

        public long EvenSum
        {
            get { return evenSum; }
            set { evenSum = value; }
        }


        public long Fibonacci()
        {
            FibonacciRecurssion(0, 1, 4000000);
            return EvenSum;
        }

        public void FibonacciRecurssion(int a, int b, int maxNumber)
        {
            Console.WriteLine(a.ToString() + "    ");
            if (a % 2 == 0) EvenSum = EvenSum + a;
            if(a < maxNumber)
            {
                FibonacciRecurssion(b, a + b, maxNumber);
            }
        }
    }

    
}
