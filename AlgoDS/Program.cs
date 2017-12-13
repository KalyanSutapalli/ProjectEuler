using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution.MainLeftRotation(new string[] { });
            //SpraceArrays.MainSpraceArrays(new string[] { });
            //SolutionArrayManipulation.MainArrayManipulation(new string[] { });
            //AlgoDS.HackerRank.LinkedList.Reverse(new HackerRank.Node { Data = 1, Next = new HackerRank.Node { Data = 2, Next = new HackerRank.Node { Data = 3, Next = new HackerRank.Node { Data = 4, Next = new HackerRank.Node { Data = 5, Next = null } } } } });
            //Console.ReadLine();

            //int numberofLoops = int.Parse(Console.ReadLine());
            //int m = 0;
            //int k = 0;
            //int n = 0;
            //for (int i = 0; i < numberofLoops; i++)
            //{
            //    string[] inputString = Console.ReadLine().Split(' ');
            //    m = int.Parse(inputString[0]);
            //    k = int.Parse(inputString[1]);
            //    n = int.Parse(inputString[2]);
            //    GetKthChar(m, k, n);
            //}

            //HackerRank.TotalNumberofStrings totalStrings = new HackerRank.TotalNumberofStrings();
            //Console.WriteLine(totalStrings.TotalStrings(3, 1, 2));
            //Console.WriteLine(totalStrings.TotalStrings(3, 1, 2));
            //Console.WriteLine(totalStrings.TotalStrings(5, 1, 2));
            //Console.ReadLine();

            MaxTipCalculator(5, 3, 3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 });


        }

        public static void MaxTipCalculator(int N, int X, int Y, int[] maxRahul, int[] maxAnkit)
        {
            maxRahul = BubbleSort(maxRahul);
            maxAnkit = BubbleSort(maxAnkit);

            int sumOfTip = 0;
            for (int i = 0; i < X + Y; i++)
            {

            }
        }

        public static int[] BubbleSort(int[] arrayToSort)
        {
            bool isSorted = false;
            int tempNumber = 0;
            while (isSorted == false)
            {
                isSorted = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] < arrayToSort[i + 1])
                    {
                        isSorted = false;
                        tempNumber = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = tempNumber;
                    }
                }
            }
            return arrayToSort;
        }

        public static void GetKthChar(int m, int k, int n)
        {
            GetBinaryNumber(m);
            string finalBinaryString = string.Empty;
            while (binaryStack.Count != 0)
            {
                finalBinaryString = finalBinaryString + binaryStack.Pop().ToString();
            }
            Console.WriteLine(finalBinaryString);

            StringBuilder tempString = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                tempString = new StringBuilder();
                for (int j = 0; j < finalBinaryString.Length; j++)
                {
                    if (finalBinaryString[j].ToString() == "0")
                    {
                        tempString.Append("01");
                    }
                    else
                    {
                        tempString.Append("10");
                    }
                }
                finalBinaryString = tempString.ToString();
            }

            Console.WriteLine(finalBinaryString[k]);
        }

        static int reminder = 0;
        static Stack<int> binaryStack = new Stack<int> { };
        private static void GetBinaryNumber(int numberToConvert)
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
