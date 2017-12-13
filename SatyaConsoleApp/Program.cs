using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Asynchronos process" + Environment.NewLine);
            Method1();
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("This is syncronos process with value: " + i);
            }
            Console.ReadLine();
        }

        static void Method3()
        {

        }


        async static Task Method1()
        {
            var _returnValue = await Method2();
            Console.WriteLine(Environment.NewLine + "Call to Aynchronos process Completed with Value " + +_returnValue);
        }

        private static Task<Int32> Method2()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                return 1;
            });
        }
    }
}
