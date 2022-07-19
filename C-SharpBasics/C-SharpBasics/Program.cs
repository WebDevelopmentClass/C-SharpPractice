using System;

namespace C_SharpBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int , string, float, double , char, longint, bool

            //var fName = "John";
            //var lName = "Miller";

            //var fullName = fName + lName;

            //Console.WriteLine(fullName);

            // Instantiating the operator class


            //int c = 2 + 2*2 / 2 - 2;
            //Console.WriteLine(c);

            // Ternary Operator for conditonal Statement



             Conditional conditional = new Conditional();
             var checkAge = conditional.CheckAge(10);

            string message = checkAge  ? "USer is eligible for drink" : "User is not eligible for drink";

            Console.WriteLine(message);
            conditional.CheckMarks(100,34);
            //Operators oper = new Operators();
            //oper.age = 30;

            //Methods methods = new Methods();
            //methods.PrintMyName();
            //var value = methods.SumOfTwoNumbers();
            //var fullName = methods.GetFullName();

            //Console.WriteLine(fullName);
            //Console.WriteLine("Sum of two numbers is: {0}", value);   
            

            //Console.WriteLine("Enter Student name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Student age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Roll number");
            //int rollno= int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Subject Name"); ;
            //string subject= Console.ReadLine();


            //Console.WriteLine($"Name of Student is {name} \n Age: {age} \n Roll Number: {rollno} \n Selected subject: {subject}");

        }
    }
}




/*
 
 int age;
string name;
 Car car;


 
 */