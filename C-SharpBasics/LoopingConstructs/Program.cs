using System;
using System.Collections.Generic;

namespace LoopingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Subject> subjects = new List<Subject>
            {
                 new Subject{ SubjectCode = 101,SubjectName= "SCIENCE", SubjectType="SCI-FI"},
                 new Subject{ SubjectCode = 102,SubjectName= "HINDI", SubjectType="LIT"},
                 new Subject{ SubjectCode = 103,SubjectName= "ENGLISH", SubjectType="ENG"},
                 new Subject{ SubjectCode = 104,SubjectName= "LITERATURE", SubjectType="LIT"},
            };

            List<Student> students = new List<Student> { new Student { Name = } }

            List<City> cities = new List<City>();

            Student student = new Student();
            student.Name = "Harman Kaur";
            student.Age = 25;
            student.RollNumber = 1;
          //  student.Standard = "Btech";
            student.Subjects = subjects;



            Console.WriteLine($"Name Of Student is: {student.Name}");
            Console.WriteLine($"Age Of Student is: {student.Age}");
            Console.WriteLine($"Roll Of Student is: {student.RollNumber}");
            //Console.WriteLine($"Standard Of Student is: {student.Standard}");
            foreach (var item in student.Subjects)
            {
                Console.WriteLine($"\t\t Subject Code is {item.SubjectCode}");
                Console.WriteLine($"\t\t Subject Code is {item.SubjectName}");
                Console.WriteLine($"\t\t Subject Code is {item.SubjectType}");
                Console.WriteLine($"\n");
            }
            //ReadProperties();
            //Snumber();

            //Console.WriteLine("Learning Array");
            //ArrayLesson array = new ArrayLesson();
            //array.ArrayProg();

            //ForLoop loop = new ForLoop();
            //loop.ForeachLoop();
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
            Student student = new Student();

            Console.WriteLine("Enter Student name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine(student.Name);

            // TO DO : Complete this student read al properties

            List<string> listOfString;
            // changes 


        }




    }
}
