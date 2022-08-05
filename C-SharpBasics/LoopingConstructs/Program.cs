using System;
using System.Collections.Generic;

namespace LoopingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadProperties();
            //Snumber();

            Console.WriteLine("Learning Array");
            //ArrayLesson array = new ArrayLesson();
            //array.ArrayProg();

            ForLoop loop = new ForLoop();
            loop.ForeachLoop();
        }
        public static void Snumber()
        {
            // Take 10 numbers input from user using array and for loop
            // Initalize an empty array with specific length
            int[] serialNumber = new int[10];

            // loop through the length of 10 
            // and asking user to input and assigning to the array
            for (int i = 0; i < 10; i++)
            {
                serialNumber[i] = int.Parse(Console.ReadLine());
            }

            // Printing the input array
            for (int i = 0; i < serialNumber.Length; i++)
            {
                Console.WriteLine($"Serial Number: {serialNumber[i]}");
            }
        }

        public static void ReadProperties()
        {
            Student student= new Student();

            Console.WriteLine("Enter Student name: ");
            student.Name = Console.ReadLine();  

            Console.WriteLine(student.Name);

            // TO DO : Complete this student read al properties

            List<string> listOfString;
            // changes 
     
           
        }




    }
}
