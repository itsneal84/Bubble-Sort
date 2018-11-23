using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsActivity1
{
    class MainController
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            string[] list = { "Brian", "Dona", "Anna", "Tom", "Ian", "Bob", "Guy", "Iona", "Jack", "Jim", "Joe", "Mark", "Nadia" };

            int[] list2 = { 25, 19, 11, 80, 1, 45, 60, 24, 82, 12, 30, 20, 76, 34, 10, 47 };

            list = logic.BubbleSortStrings(list);

            Stopwatch rolex = Stopwatch.StartNew();            

            foreach (string name in list)
            {
                Console.Write(name + " ");
            }

            rolex.Stop();

            Console.WriteLine("Time taken: {0}ms", rolex.Elapsed.TotalMilliseconds);

            Stopwatch rolex2 = Stopwatch.StartNew();

            logic.ShellSortingIntegers(list2);
            //logic.InsertionSortIntegers(list2);

            foreach (int number in list2)
            {
                Console.Write(number + " ");
            }

            rolex.Stop();

            Console.WriteLine("Time taken: {0}ms", rolex2.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
