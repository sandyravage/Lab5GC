using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            while (true)
            {
                Console.WriteLine("Enter an integer that's greater than 0 but less than 66");
                ulong factnum = 0;
                try
                {
                    factnum = ulong.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Can you not?");
                    continue;
                }

                if (factnum is System.UInt64 && factnum < 66)
                {

                }
                else
                {
                    Console.WriteLine("Come on now.");
                    continue;
                }

                ulong Factorial(ulong i)
                {
                    if (i <= 1)
                    {
                        return i;
                    }
                    return i * Factorial(i - 1);
                }

                Console.WriteLine("The Factorial of " + factnum + " is: " + Factorial(factnum));

            please:
                string Continue;
                Console.WriteLine("Continue? (y/n)");
                Continue = Console.ReadLine();
                if (Continue == "n")
                {
                    break;
                }
                else if (Continue == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Must you try my patience?");
                    goto please;
                }
            }
        }
    }
}
