using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS.HackerRank
{
    public class FindKthChar
    {
        public FindKthChar()
        {
            int m = 15666;
            int k = 12;
            int n = 20;

            GetBinaryNumber(m);
            string finalBinaryString = string.Empty;
            while (binaryStack.Count != 0)
            {
                finalBinaryString = finalBinaryString + binaryStack.Pop().ToString();
            }
            Console.WriteLine(finalBinaryString);

            string tempString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                tempString = string.Empty;
                for (int j = 0; j < finalBinaryString.Length; j++)
                {
                    tempString = (finalBinaryString[j].ToString() == "0") ? tempString + "01" : tempString + "10";
                }
                finalBinaryString = tempString;
            } 

            Console.WriteLine(finalBinaryString[k]);
            Console.ReadLine();
        }


        int reminder = 0;
        Stack<int> binaryStack = new Stack<int> { };
        private void GetBinaryNumber(int numberToConvert)
        {
            if (numberToConvert == 0 || numberToConvert == 1) binaryStack.Push(numberToConvert);
            else
            {
                reminder = numberToConvert % 2;
                binaryStack.Push(reminder);
                GetBinaryNumber(numberToConvert / 2);
            }

        }
    }
}
