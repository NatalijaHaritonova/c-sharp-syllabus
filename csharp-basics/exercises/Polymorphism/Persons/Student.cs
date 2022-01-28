using System;

namespace Persons
{
    internal class Student : Person
    {
        private double _gpa = 0;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public Student(string firstName, string lastName, string adress, int id, double gpa) : base(firstName, lastName, adress, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName} details: ");
            Console.WriteLine($"Adress: {_address}");
            Console.WriteLine($"GPA: {_gpa}");
            Console.WriteLine($"ID: {_id}");
        }
    }
}
