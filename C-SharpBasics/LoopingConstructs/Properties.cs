using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingConstructs
{
    internal class Properties
    {
        int age = 20;
        public int Age { get; set; }
    }

    // model 
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int RollNumber { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    internal class Subject
    {
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string SubjectType { get; set; }
    }

    internal class Standard
    {
        public string Standards { get; set; }
        public List<Student> Students { get; set; }
    }
    internal class City
    {
        public string CityName { get; set; }
        public string PinCode { get; set; }
    }
}

