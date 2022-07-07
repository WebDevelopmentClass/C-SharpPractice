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

            Console.WriteLine("Enter Student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Roll number");
            int rollno= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject Name"); ;
            string subject= Console.ReadLine();


            Console.WriteLine($"Name of Student is {name} \n Age: {age} \n Roll Number: {rollno} \n Selected subject: {subject}");

        }
    }
}
