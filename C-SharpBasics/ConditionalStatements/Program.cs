using System;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opstate opstate = new Opstate();
            //Console.WriteLine("Enter any Character:");
            //Char a = char.Parse(Console.ReadLine());

            //var Checkchar = opstate.ConditionalState(a);

            //string message = Checkchar ? "Entered Character is Vowel" : "Entered Character is Consonant";

            //Console.WriteLine(message);


            //Console.WriteLine("Enter any three number:");
            //int a = int.Parse(Console.ReadLine());
            //int b =int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int message = opstate.MaxThreeNumbers(a, b, c); 
            // Statement which does not follow some rules
            //Console.WriteLine("Largest number is {0}",message);

            try
            {
                string name = "Harman";
                Console.Write(int.Parse(name));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }


            //int num1 = 5;
            //int num2 = 5;
            //string number = "5";
            //string number2 = "5";

            ////Boxing
            //var aa = num1.ToString();

            //Console.WriteLine(num1+num2);
            //Console.WriteLine(number + number2);

            //Console.WriteLine(num1 + number2);


            //int a = opstate.SumofNaturalNumbers();

            //Console.WriteLine("Sum of first 10 natural numbers is {0}", a);            
        }

    }
}
