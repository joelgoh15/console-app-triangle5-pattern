using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portfolio10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            Console.WriteLine("A console application that draws the triangle5 pattern base on user input value.");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            string strSizeTriangle5Pattern;
            int sizeTriangle5Pattern;
            sizeTriangle5Pattern = 0;
            do
            {
                Console.Write("Please enter size of triangle5 pattern (enter -1 to exit):");
                try
                {
                    strSizeTriangle5Pattern = Console.ReadLine();
                    strSizeTriangle5Pattern = strSizeTriangle5Pattern.Trim();
                    sizeTriangle5Pattern = Convert.ToInt16(strSizeTriangle5Pattern);
                    if ((sizeTriangle5Pattern % 2) == 0)
                    {
                        Console.WriteLine("enter only odd integer value for size of triangle5 pattern.");
                        continue;
                    }
                    if (sizeTriangle5Pattern < 3)
                    {
                        Console.WriteLine("please enter value that is more than 3.");
                        continue;
                    }
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("please enter a valid input. please enter an integer.");
                    continue;
                }
                ClassPatternTriangle5.DramTriangle5Pattern(sizeTriangle5Pattern);
                Console.Write("\n\n");
            } while (sizeTriangle5Pattern != -1);
            Console.WriteLine("program exit.");
            Console.WriteLine("press any button to exit.");
            Console.ReadLine();
        }
    }
}
