using System;

namespace CSharpMethods
{
    internal class Program
    {
        static void Main()
        {
            int a;
            int b;

            Functions function = new Functions();

            Console.WriteLine("Calculations for sum of two numbers");
            Console.WriteLine("Enter First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", function.SumofTwoNumber(a, b));

        }
    }
}
