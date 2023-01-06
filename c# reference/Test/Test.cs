﻿// We create an object of a class (another script) within this script
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySweetProgram
{
    class RunProgram
    {
        public static void Main(string[] args)
        {
            List<string> firstNames = new List<string>(){"Caleb", "Janna", "Vladimir"};
            List<string> lastNames = new List<string>(){"Evdokimov", "Rtveliashvili", "Tazev"};   

            List<Student> students = new List<Student>();   // Create a list and add these objects

            for(int i = 0; i < firstNames.Count; i++)    // (initializer; condition; iterator)
            {
                Student student = new Student();
                student.FirstName = firstNames[i];
                student.LastName = lastNames[i];
                students.Add(student);
            }

            // take the first object from `students` list and pass it to the method `takeStudent`
            takeStudents2(students[0]);
            takeStudents(students[0]);
            // do the same directly
            Console.WriteLine(students[0].FullName);
        }
    
        public static void takeStudents(Student student)
        {
            Console.WriteLine(student.FirstName);
            student.FirstName = "Cassandra";
            Console.WriteLine(student.FullName);
        }

        public static void takeStudents2(Student student)
        {
            student = new Student();
            student.FirstName = "Pupi";
            Console.WriteLine(student.FullName);
        }
    }
}