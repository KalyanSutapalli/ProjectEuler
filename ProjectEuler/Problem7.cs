using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        private long nthPrimeNumber = 0;
        private long loopCounter = 0;
        private long primeCounter = 3;
        private long NumberToCheck = 0;

        public long GetnthPrime(long nthPosition)
        {
            NumberToCheck = 7;        
            while (primeCounter <= nthPosition)
            {
                loopCounter = 0;
                GetnthPrimeNumber(NumberToCheck + 2, nthPosition);
            }
            return nthPrimeNumber;
        }



        public void GetnthPrimeNumber(long numberToCheck, long nthPosition)
        {
            bool isPrime = true;
            NumberToCheck = numberToCheck;
            loopCounter++;
            for (int i = 2; i <= Math.Sqrt(numberToCheck); i++)
            {
                if (numberToCheck % i == 0) { isPrime = false; break; }
            }
            if (isPrime == true)
            {
                primeCounter++;
                if (primeCounter > 9988) Console.WriteLine(primeCounter + "   " +  nthPrimeNumber);
                nthPrimeNumber = numberToCheck;
            }

            if (loopCounter == 1000)
                return;

            if (primeCounter <= nthPosition)
                GetnthPrimeNumber(numberToCheck + 2, nthPosition);
        }
    }
}
