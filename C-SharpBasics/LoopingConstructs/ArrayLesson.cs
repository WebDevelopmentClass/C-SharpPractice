using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingConstructs
{
    internal class ArrayLesson
    {
        public void ArrayProg()
        {
            int[] rollNumbers = { 1,3,6,7,8,9, 10, 11}; // Hard coding
            Console.WriteLine(rollNumbers);
            int[] age= { };
            age[0] = 1;
            age[1] = 2;
            age[2] = 3;
            age[3] = 4;
            age[4] = 5;
            age[5] = 6; 
            age[6] = 7; 
            age[7] = 8; 
            age[8] = 9; 
            age[9] = 10;

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
