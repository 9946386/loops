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
            /*
            //Make a for loop, 
            Console.WriteLine("Task 1");
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
             * while (counter <= finish)*//*
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

            Console.WriteLine("End of Do While Loop and task 1, press enter to exit");
            Console.ReadLine();
            Console.Clear();

            */
            /*
            Console.WriteLine("Task 2");

            //For loop
            Console.WriteLine("For Loop");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x 7 = {1}", i, i * 7);
            }
            Console.ReadLine();

            //While
            Console.WriteLine("While");

            int a = 1;
            while (a <= 12)
            {
                Console.WriteLine("{0} x 7 = {1}", a, a * 7);
                a++;
            }
            Console.ReadLine();

            //Do While
            Console.WriteLine("Do While");
            a = 1;
            do
            {
                Console.WriteLine("{0} x 7 = {1}", a, a * 7);
                a++;
            } while (a <= 12);

            Console.ReadLine();
            Console.Clear();
            */
            /*
            Console.WriteLine("Task 3");

            //For Loop
            Console.WriteLine("For Loop");

            Console.WriteLine("Number\t\tSquare\t\tCube");
            Console.WriteLine("______\t\t______\t\t____");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", i, i * i, i * i * i);
            }
            Console.ReadLine();

            //While

            Console.WriteLine("While");

            int c = 0;
            while (c <= 10)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c, c * c, c * c * c);
                c++;
            }
            Console.ReadLine();

            //Do While

            Console.WriteLine("Do While");

            c = 0;
            do
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c, c * c, c * c * c);
                c++;
            } while (c <= 10);

            Console.ReadLine();
            Console.Clear();
            */

            Console.WriteLine("Task 4");

            //While

            Console.WriteLine("While");

            int start = 76;
            int finish = 46;

            Console.WriteLine("Display odd numbers from 76 to 46 (decending)");
                        
            while(start >= finish)
            {
                if(start % 2 != 0)
                    Console.WriteLine(start);
                start--;
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task 5");

            Console.Write("Please enter a character: ");
            Console.ReadLine();
            string char1;
            Console.Write("How many times would you like that to repeat?");
            int num1 = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num1; i++)
            {
                Console.WriteLine(char1);
            }
            Console.ReadLine();



        
            

         
            
        




        }
    }
}
