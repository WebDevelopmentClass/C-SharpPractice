using System;
using System.Collections.Generic;

namespace LoopingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mocking 
            List<Subject> subjects = new List<Subject>
            {

            };

            //List<Student> students = new List<Student>
            //{
            //    new Student
            //    { Id = 1, Name= "Harman Kaur", Age = 25, RollNumber = 1, Subjects = new List<Subject>
            //    {
            //     new Subject{ SubjectCode = 101,SubjectName= "SCIENCE", SubjectType="SCI-FI"},
            //     new Subject{ SubjectCode = 102,SubjectName= "HINDI", SubjectType="LIT"},
            //     new Subject{ SubjectCode = 103,SubjectName= "ENGLISH", SubjectType="ENG"},
            //     new Subject{ SubjectCode = 104,SubjectName= "LITERATURE", SubjectType="LIT"}
            //    }
            //    },
            //    new Student
            //    {
            //     Id = 1, Name= "Harman Kaur", Age = 25, RollNumber = 1, Subjects = new List<Subject>
            //    {
            //     new Subject{ SubjectCode = 101,SubjectName= "SCIENCE", SubjectType="SCI-FI"},
            //     new Subject{ SubjectCode = 102,SubjectName= "HINDI", SubjectType="LIT"},
            //     new Subject{ SubjectCode = 103,SubjectName= "ENGLISH", SubjectType="ENG"},
            //     new Subject{ SubjectCode = 104,SubjectName= "LITERATURE", SubjectType="LIT"}
            //    }
            //    },
            //     new Student
            //     {
            //      Id= 2,Name="John", Age=30,RollNumber=2,Subjects= new List<Subject>
            //      {
            //          new Subject{ SubjectCode=201,SubjectName="Math",SubjectType= "JBL-MH"},
            //          new Subject{ SubjectCode=202, SubjectName="C",SubjectType= "JBL-C"}
            //      }
            //     },
            //     new Student
            //     {
            //         Id= 3,Name="Mike",Age= 22, RollNumber=2, Subjects=new List<Subject>
            //         {
            //         new Subject { SubjectCode = 301, SubjectName ="English", SubjectType="CD-Eng"}
            //         }
            //     },
            //};



            //Standard std = new Standard();
            //std.Standards = "Btech.";
            //std.Students = students;

            //Console.WriteLine(std.Standards);

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Name Of Student is: {item.Name}");
            //    Console.WriteLine($"Age Of Student is: {item.Age}");
            //    Console.WriteLine($"Roll Of Student is: {item.RollNumber}");
            //    foreach (var sub in item.Subjects)
            //    {
            //        Console.WriteLine($"\t\t Subject Code is {sub.SubjectCode}");
            //        Console.WriteLine($"\t\t Subject Name is {sub.SubjectName}");
            //        Console.WriteLine($"\t\t Subject Type is {sub.SubjectType}");
            //        Console.WriteLine($"\n");
            //    }
            //}

            List<Standard> standard = new List<Standard>
            {
                new Standard
                {
                      Standards= "Msc",
                      Students= new List<Student>
                      {
                        new Student
                        {
                                     Id= 100,
                                     Name = "Norman",
                                     Age = 35,
                                     RollNumber= 10,
                                     Subjects = new List<Subject>
                                     {
                                         new Subject { SubjectCode = 101, SubjectName = "ASP.Net", SubjectType= "JBL-ASP"},
                                         new Subject { SubjectCode = 101, SubjectName = "ASP.Net", SubjectType= "JBL-ASP"},
                                         new Subject { SubjectCode = 101, SubjectName = "ASP.Net", SubjectType= "JBL-ASP"}
                                     }
                        },
                        new Student
                        {
                          Id = 101, Name= "Carlos", Age= 34, RollNumber= 11, Subjects =new List<Subject>
                          {new Subject{ SubjectCode= 102, SubjectName= "ASP.Net", SubjectType= "JBL-ASP"}
                          }
                        }
                      }
                     
                },

                new Standard
                {
                    Standards= "BCA", Students =  new List<Student>
                    {
                        new Student {
                            Id= 103, Name= "Marcus", Age= 40, RollNumber= 12, Subjects= new List<Subject>
                            {
                                new Subject{ SubjectCode= 103, SubjectName= " Data Structure", SubjectType= "JBL-DS"}
                            }
                        }
                    }

                }
            };
         


            foreach (var stds in standard)
            {
                Console.WriteLine($"Student Standard:{stds.Standards}");
                foreach (var item in stds.Students)
                {
                    Console.WriteLine($"Student Standard:{item.Name}");
                    foreach (var sub in item.Subjects)
                    {
                        Console.WriteLine($"Student Standard:{sub.SubjectName}");
                    }
                }
            }

            //Console.WriteLine($"Standard Of Student is: {student.Standard}");
            //foreach (var item in student.Subjects)
            //{
            //    Console.WriteLine($"\t\t Subject Code is {item.SubjectCode}");
            //    Console.WriteLine($"\t\t Subject Code is {item.SubjectName}");
            //    Console.WriteLine($"\t\t Subject Code is {item.SubjectType}");
            //    Console.WriteLine($"\n");
            //}
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
