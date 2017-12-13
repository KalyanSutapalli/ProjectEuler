using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS.HackerRank
{
    public class TotalNumberofStrings
    {
        //Given 3 characters a, b, c. Find the number of strings of length n that can be formed from these 3 characters. Given that : we can use ‘a’ as many times as we want, ‘b’ maximum once, 
        //and ‘c’ maximum twice.
        
        public int TotalStrings(int n, int bCount, int cCount)
        {          

            if (bCount < 0 || cCount < 0) return 0;
            if (bCount == 0 && cCount == 0)
            {
                //Console.WriteLine("Both are 0");
                return 1;
            }
            if (n == 0)
            {
                //Console.WriteLine("N is o");
                return 1;
            }     
            return TotalStrings(n - 1, bCount, cCount) + TotalStrings(n - 1, bCount - 1, cCount) + TotalStrings(n - 1, bCount, cCount - 1);
        }
    }     
}
