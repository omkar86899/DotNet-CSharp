using System;
using System.Collections.Generic;
using System.Linq;
using LinqStudentApp.Model;

namespace DeferredAndImmediateExecution
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

            var top5_StudentsByCgpaDefferedExecution = students.OrderByDescending(student => student.Cgpa)
                                                               .Take(5);
            var top5_StudentsByCgpaImmediateExecution = top5_StudentsByCgpaDefferedExecution.ToList();

            students.Add(new Student("sagar", "mumbai", 8.1f));

            Console.WriteLine("Top 5 Students Based On CGPA(Deffered Execution): ");
            PrintStudentDetails(top5_StudentsByCgpaDefferedExecution);
            Console.WriteLine("\nTop 5 Students Based On CGPA(Immediate Execution): ");
            PrintStudentDetails(top5_StudentsByCgpaImmediateExecution);
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
