using System;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opstate opstate = new Opstate();
            //Console.WriteLine("Enter any Character:");
            //Char a = char.Parse(Console.ReadLine());

            //var Checkchar = opstate.ConditionalState(a);

            //string message = Checkchar ? "Entered Character is Vowel" : "Entered Character is Consonant";

            //Console.WriteLine(message);


            Console.WriteLine("Enter any three number:");
            int a = int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int message = opstate.MaxThreeNumbers(a, b, c); 
            Console.WriteLine("Largest number is {0}",message);
            
        }
    }
}
