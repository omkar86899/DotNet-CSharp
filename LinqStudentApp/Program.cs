using System;
using System.Collections.Generic;
using System.Linq;
using LinqStudentApp.Model;

namespace LinqStudentApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("omkar", "thane", 7.1f));
            students.Add(new Student("sachin", "pune", 7.7f));
            students.Add(new Student("vaibhav", "mumbai", 9.1f));
            students.Add(new Student("rahul", "mulund", 7.2f));
            students.Add(new Student("nikhil", "kalyan", 8.2f));
            students.Add(new Student("sagar", "mumbai", 8.1f));

            var studentsListByTheierCgpa = students.OrderByDescending(student => student.Cgpa)
                                                    .Take(5);
            var studentsInMumbai = students.Where(student => student.Location.Equals("mumbai"));
            var studentsInMumbaiInAscendingOrder = studentsInMumbai.OrderBy(student => student.Name);
            var studentsNameAndCgpa = students.Select(student => new { student.Name, student.Cgpa});

            Console.WriteLine("Top 5 Students Based On CGPA: ");
            PrintStudentDetails(studentsListByTheierCgpa);
            Console.WriteLine("\nStudents who lives in mumbai: ");
            PrintStudentDetails(studentsInMumbai);
            Console.WriteLine("\nStudents who lives in mumbai in Asending Order By Their Names: ");
            PrintStudentDetails(studentsInMumbaiInAscendingOrder);
            Console.WriteLine("\nStudents Name and Cgpa: ");
            PrintStudentNameAndCgpa(studentsNameAndCgpa);
        }

        private static void PrintStudentNameAndCgpa(IEnumerable<object> studentsNameAndCgpa)
        {
            foreach(Object student in studentsNameAndCgpa)
            {
                Console.WriteLine(student);
            }
        }

        private static void PrintStudentDetails(IEnumerable<Student> students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine("Name: {0}, Location: {1}, CGPA: {2}", student.Name, student.Location, student.Cgpa);
            }
        }
    }
}
