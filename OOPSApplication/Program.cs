using OOpsClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolSystem schoolSystem = SchoolSystem.GetInstance();

            SchoolFactory factory = new SchoolFactory();

           

            schoolSystem.Students.Add(factory.CreateStudent("Pavan", "A"));
            schoolSystem.Students.Add(factory.CreateStudent("Kalyan", "B"));
            schoolSystem.Students.Add(factory.CreateStudent("Vinay", "A"));
            schoolSystem.Students.Add(factory.CreateStudent("Jay", "B"));


            schoolSystem.Teachers.Add(factory.CreateTeacher("Guru", "A"));
            schoolSystem.Teachers.Add(factory.CreateTeacher("Thulasi", "B"));

            schoolSystem.Teachers.Add(factory.CreateTeacher("Kumar", "A"));
            schoolSystem.Teachers.Add(factory.CreateTeacher("Vijay", "B"));

            // Create and add subjects to the school system
            schoolSystem.Subjects.Add(factory.CreateSubject("Math", "101", schoolSystem.Teachers[0]));
            schoolSystem.Subjects.Add(factory.CreateSubject("Science", "102", schoolSystem.Teachers[1]));

            schoolSystem.Subjects.Add(factory.CreateSubject("History", "103", schoolSystem.Teachers[2]));
            schoolSystem.Subjects.Add(factory.CreateSubject("English", "104", schoolSystem.Teachers[3]));


            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Search students in a class");
                Console.WriteLine("2. Retrieve teacher's subjects");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter the class section to search for students: ");
                            string classSection = Console.ReadLine();
                            Console.WriteLine($"Students in Class {classSection}:");
                            foreach (var student in schoolSystem.Students)
                            {
                                if (student.ClassAndSection == classSection)
                                {
                                    Console.WriteLine($"{student.Name}");
                                }
                            }
                            break;
                        case 2:
                            Console.Write("Enter the teacher's name to retrieve subjects: ");
                            string teacherName = Console.ReadLine();
                            Console.WriteLine($"Subjects taught by {teacherName}:");
                            foreach (var subject in schoolSystem.Subjects)
                            {
                                if (subject.Teacher.Name == teacherName)
                                {
                                    Console.WriteLine($"{subject.Name} ({subject.SubjectCode})");
                                }
                            }
                            break;


                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }
            }
        }


    
    }
}
