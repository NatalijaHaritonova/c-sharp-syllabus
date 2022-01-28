using System;

namespace Persons
{
    internal class Employee : Person
    {
        private string _jobTitle = String.Empty;

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle) : base(firstName, lastName, adress, id)
        {
            _jobTitle += jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName} details: ");
            Console.WriteLine($"Adress: {_address}");
            Console.WriteLine($"Job: {_jobTitle}");
            Console.WriteLine($"ID: {_id}");
        }
    }
}
