using System;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opstate opstate = new Opstate();
            Console.WriteLine("Enter any Character:");
            Char a = char.Parse(Console.ReadLine());

            var Checkchar = opstate.ConditionalState(a);

            string message = Checkchar ? "Entered Character is Vowel" : "Entered Character is Consonant";

            Console.WriteLine(message);
        }
    }
}
