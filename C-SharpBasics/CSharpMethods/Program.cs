using System;

namespace CSharpMethods
{
    internal class Program
    {
        static void Main()
        {

            // Operators + , _ , / , % , *
            // BODMAS
            // 2+2 (3*4)
            int a;
            int b;

            Functions function = new Functions();

            Console.WriteLine("Calculations for sum of two numbers");
            Console.WriteLine("Enter First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe sum of two numbers is : {0} \n", function.SumofTwoNumber(a, b));

            // Area of Triangle 
            Console.WriteLine("Enter the base of triangle: ");
            double triangleBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of triangle: ");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n The area of Trinagle is : {0} \n",function.AreaofTriangle(triangleBase,triangleHeight));

         }
    }
}
