using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portfolio10_4
{
    internal class ClassPatternTriangle5
    {
        public static void DrawTriangle5Pattern(int sizeTriangle5Pattern)
        {
            int midSizeTriangle5Pattern;
            midSizeTriangle5Pattern = (sizeTriangle5Pattern / 2) + 1;
            int spaceCounter;
            spaceCounter = midSizeTriangle5Pattern - 1;
            int plusMinusCounter = 1;
            for (int i = 0; i <= sizeTriangle5Pattern; i++)
            {
                if (i < midSizeTriangle5Pattern)
                {
                    for (int j = 0; j < spaceCounter; j++)
                    {
                        Console.Write(" ");
                    }
                    spaceCounter = spaceCounter - 1;
                    for (int k = 0; k < plusMinusCounter; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write("+");
                        } 
                        else 
                        {
                            Console.Write("-");
                        }
                    }
                    plusMinusCounter = plusMinusCounter + 2;
                    Console.WriteLine();
                }
            }
        }
    }
}
