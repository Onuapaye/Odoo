using System;
using System.Collections;


namespace OdooTest
{
    class Test4
    {
       
        int index = 0;
        int sum = 0;

        public int SumOfListItemsRecursive(ArrayList listOfItems)
        {

            if (index < listOfItems.Count)
            {
                if (listOfItems[index].GetType() == typeof(Int32))
                {
                   sum += int.Parse(listOfItems[index].ToString());
                }
                
                    index += 1;
                    return SumOfListItemsRecursive(listOfItems);
            }

            Console.WriteLine("The sum of integers in the list is " + sum);
            return sum;
        }

    }
}
