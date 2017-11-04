using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SolutionArrayManipulation
{

    public static void MainArrayManipulation(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        int[] initialArray = new int[n];
        for (int a0 = 0; a0 < m; a0++)
        {
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            int k = Convert.ToInt32(tokens_a[2]);

            for (int i = a; i < b; i++)
            {
                initialArray[i - 1] = initialArray[i - 1] + k;
            }
        }
        Console.WriteLine(initialArray.Max().ToString());



    }
}
