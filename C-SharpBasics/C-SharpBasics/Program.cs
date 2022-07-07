using System;

namespace C_SharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int , string, float, double , char, longint

            //var fName = "John";
            //var lName = "Miller";

            //var fullName = fName + lName;

            //Console.WriteLine(fullName);

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

           

            Console.WriteLine($"Age of {name} is {age}");

        }
    }
}
