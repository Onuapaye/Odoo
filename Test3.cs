using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooTest
{
    class Test3
    {
        //String[] listOfStrings = [ "bismark", 15, 1, 8, "nana", "frimpong", 55, "18", "fortress"];
       
        

        public void SumOfListItems()
        {
            ArrayList listOfStrings = new ArrayList();
            listOfStrings.Add("bismark");
            listOfStrings.Add(15);
            listOfStrings.Add(1);
            listOfStrings.Add(8);
            listOfStrings.Add("nana");
            listOfStrings.Add("frimpong");
            listOfStrings.Add(55);
            listOfStrings.Add(18);
            listOfStrings.Add("fortress");

            int sum = 0;
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.Write(listOfStrings[i] + " " + listOfStrings[i].GetType().Name);
                if ( listOfStrings[i].GetType() == typeof(Int32))
                {
                    sum += int.Parse(listOfStrings[i].ToString());
                }
            }

            Console.WriteLine("The sum of integers in the list is " + sum);
        }
    }
}
