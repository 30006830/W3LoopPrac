using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 5;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" N\t\tN*10\t\tN*100\t\tN*1000 ");
            Console.WriteLine("\n");
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($" {i}\t\t{i*10}\t\t{i*100}\t\t{i*1000}");
            }
            Console.WriteLine("End of the for loop...");
            Console.WriteLine("\n");

            int counter = 1;
            while(counter <= finish)
            {
                Console.WriteLine($"{counter}\t\t{counter*10}\t\t{counter*100}\t\t{counter*1000}");
                counter++;
            }
            Console.WriteLine("End of the while loop...");
            Console.WriteLine("\n");

            counter = 1;
            do {

                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;
            }
            while (counter <= finish) ;
            Console.WriteLine("End of the do while loop...");
            Console.ReadLine();
           
        }
    }
}
