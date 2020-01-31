using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "Karthik", marks = 40 });
            students.Add(new Student() { ID = 2, Name = "Rahul", marks = 50 });
            students.Add(new Student() { ID = 3, Name = "Vivek", marks = 60 });
            students.Add(new Student() { ID = 4, Name = "Adithya", marks = 70 });
            IsPassedDelegate isPassed = new IsPassedDelegate(IsPassed);
            Student.PromoteStudent(students, isPassed);
            Console.Read();
        }
        public static bool IsPassed(Student student)
        {
            if (student.marks > 40)
            {
                return true;
            }
            return false;
        }
    }
    public delegate bool IsPassedDelegate(Student student);
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int marks { get; set; }
        public static void PromoteStudent(List<Student> studentList,IsPassedDelegate isPassed)
        {
            foreach(Student student in studentList)
            {
                if (isPassed(student))
                {
                    Console.WriteLine(student.Name+" is Passed.");
                }
            }
        }
    }
}
