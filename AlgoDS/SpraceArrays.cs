using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS
{
    class SpraceArrays
    {
        public static void MainSpraceArrays(String[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            List<string> listOfString = new List<string> { };
            for (int i = 0; i < numberOfStrings; i++)
            {
                listOfString.Add(Console.ReadLine());
            }
            int numberOfQueries = int.Parse(Console.ReadLine());
            List<string> listOfQueries = new List<string> { };
            for (int i = 0; i < numberOfQueries; i++)
            {
                listOfQueries.Add(Console.ReadLine());
            }

            int numberOfOccurences = 0;
            foreach (string query in listOfQueries)
            {
                numberOfOccurences = listOfString.FindAll(p => p.ToString() == query).Count;
                Console.WriteLine(numberOfOccurences);
            }
        }
    }
}


