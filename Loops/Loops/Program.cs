using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a for loop, 

            Console.WriteLine("N\t\tN*10\t\t*100\t\tN*1000");
            for (int i = 3; i <= 7; i++)
            // starts at 3, finishes at 7, changes the value
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, i * 10, i * 100, i * 1000);
                // \t = tab
            }
            Console.WriteLine("End of for loop");
            Console.ReadLine();

            //While Loop

            int counter = 3;
            while (counter <= 7)

            /*or finish = 7
             * while (counter <= finish)*/
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", counter, counter * 10, counter * 100, counter * 1000);
                counter++;
            }

            Console.WriteLine("End of while loop");
            Console.ReadLine();

            //Do While Loop

            counter = 3;         
            do
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", counter, counter * 10, counter * 100, counter * 1000);
                counter++;
            } while (counter <= 7);

            Console.ReadLine();

            
        




        }
    }
}
