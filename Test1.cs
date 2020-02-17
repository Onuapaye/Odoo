using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a program that outputs sequentially the integers from 1 to 99 but on some conditions prints a string instead
/// ++ when the integer is a multiple of 3 print "Open"instead of the number,
/// ++ when it is a multiple of 7 print "Source"instead of the number,
/// ++ when it is a multiple of both 3 and 7 print "OpenSource" instead of the number.
/// </summary>
namespace OdooTest
{
    public class Test1
    {

        // a public method to print the results of the program
        public void PrintIntegersSequentially()
        {
            int numLength = 99;
            int multipleOfThree = 3;
            int multipleOfSeven = 7;


            for (int i = 1; i <= numLength; i++)
            {
                // check if i is a multiple of 3
                if ((i % multipleOfThree) == 0)
                {
                    Console.WriteLine("Open");

                    // check if i is a multiple of 7
                }
                else if ((i % multipleOfSeven) == 0)
                {
                    Console.WriteLine("Source");

                    // check if i is both a multiple of 3 and 7
                }
                else if ((i % multipleOfThree) == 0 && (i % multipleOfSeven) == 0)
                {
                    Console.WriteLine("OpenSource");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }


    }
}
