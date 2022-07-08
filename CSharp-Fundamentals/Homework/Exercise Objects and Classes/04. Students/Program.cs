using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> student = Console.ReadLine().Split(' ').ToList();
                Student std = new Student(student[0], student[1], float.Parse(student[2]));
                list.Add(std);
            }
            list =list.OrderByDescending(std => std.Grade).ToList();
            foreach (Student student in list) { Console.WriteLine(student.ToString()); }  
        }
    }
    class Student 
    {
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public float Grade { get; set; }

        public Student(string FName,string SName, float grade)
        {
            Firstname = FName;
            Secondname = SName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{Firstname:f2} {Secondname:f2}: {Grade:f2}";
        }
    }
}
