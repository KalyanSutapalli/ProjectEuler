using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5
    {
        public long MaxRecurssiveCalls = 1000;
        public long Counter = 0;
        public long FinalMutiple = 0;
        private long NumberToCheck = 1;

        public long MyProperty
        {
            get { return NumberToCheck; }
            set { NumberToCheck = value; }
        }


        public void SmallestMultipleMain(long rangeStart, long rangeEnd)
        {
            while (FinalMutiple == 0)
            {
                Counter = 0;
                SmallestMultiple(NumberToCheck, rangeStart, rangeEnd);
            }
            Console.WriteLine(FinalMutiple.ToString());
        }

        public void SmallestMultiple(long numberToCheck, long rangeStart, long rangeEnd)
        {
            NumberToCheck = numberToCheck;            
            try
            {
                bool isMultiple = true;
                for (long i = rangeStart; i <= rangeEnd; i++)
                {
                    if (numberToCheck % i != 0) { isMultiple = false; break; }
                }
                if (isMultiple == false && Counter < MaxRecurssiveCalls)
                {
                    //Console.WriteLine("Not Final Smallest Multiple: " + numberToCheck.ToString());
                    Counter++;
                    SmallestMultiple(numberToCheck + 1, rangeStart, rangeEnd);
                }
                else if (Counter >= MaxRecurssiveCalls)
                {
                    return;
                }
                else
                    FinalMutiple = NumberToCheck;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
