using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingConstructs
{
    internal class ArrayLesson
    {
        public void ArrayProg()
        {
            int[] rollNumbers = { 1,3,6,7,8,9};
            
            Console.WriteLine(rollNumbers);

            // Condition
            int i = 0;

            // While Loop
            //while(i  <= 5)
            //{
            //    Console.WriteLine(rollNumbers[i]);
            //    //if (i == 3)
            //    //    break;
            //    i++;
            //}

            // Do While Loop
            do
            {
                Console.WriteLine(rollNumbers[i]);
                i++;
            } while (i < 0);

            // Logic 

            // Increment or decreamen operator

        }
    }
}
