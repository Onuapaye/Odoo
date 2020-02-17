using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooTest
{
    class Program
    {

    

        static void Main(string[] args)
        {
            // create an instant of the Test1 class
            //Test1 test1 = new Test1();
            //test1.PrintIntegersSequentially();

            // create an instance of Test2 class
            //Test2 test2 = new Test2();
            //test2.GuessGame();

            //Test3 test3 = new Test3();
            //test3.SumOfListItems();

            //Test4 test4 = new Test4();
            //ArrayList listOfItems = new ArrayList
            //{
            //    "bismark",
            //    15,
            //    1,
            //    8,
            //    "nana",
            //    "frimpong",
            //    55,
            //    18,
            //    "fortress"
            //};

            //test4.SumOfListItemsRecursive(listOfItems);

            Test7 test7 = new Test7();
            string myFilePath = @"G:\Odoo\OdooTest\OdooTest\data.bin";
            long fileLength = 57344; // intentionally specified a bigger file size
            test7.BeginTranction(myFilePath, fileLength);

            //Test8 test8 = new Test8();
            //test8.MatchOdooExpression();
        }

    }
}
