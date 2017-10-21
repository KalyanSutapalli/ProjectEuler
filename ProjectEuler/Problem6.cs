using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {

        public long GetDifference(int rangeStart, int rangeEnd)
        {
            return GetSquareofSum(rangeStart, rangeEnd) - GetSumofSquares(rangeStart, rangeEnd) ;
        }

        public long GetSumofSquares(int rangeStart, int rangeEnd)
        {
            long sumOfSquares = 0;
            for(int i = rangeStart; i <= rangeEnd; i++)
            {
                sumOfSquares = sumOfSquares + (i * i);
            }
            return sumOfSquares;
        }

        public long GetSquareofSum(int rangeStart, int rangeEnd)
        {
            long squareOfSum = (rangeEnd * (rangeEnd + 1)) / 2;
            return squareOfSum * squareOfSum;
        }
    }
}
