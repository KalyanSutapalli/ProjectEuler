using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem2 problem = new Problem2();
            //Console.WriteLine();
            //Console.WriteLine("Event Sum   " + problem.Fibonacci().ToString());
            //Console.ReadLine();

            //Problem5 problem = new Problem5();
            //problem.SmallestMultipleMain(1, 20);
            //Console.ReadLine();

            //Problem6 problem = new Problem6();
            //Console.WriteLine(problem.GetDifference(1, 100));
            //Console.ReadLine();

            Problem7 problem = new Problem7();
            Console.WriteLine(problem.GetnthPrime(10001));
            Console.ReadLine();

        }
    }
}
