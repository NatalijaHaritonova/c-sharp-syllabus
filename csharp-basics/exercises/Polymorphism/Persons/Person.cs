using System;

namespace Persons
{
    abstract class Person
    {
        protected Person()
        {
            _firstName = "unknown";
            _lastName = "unknown";
            _address = "unknown";
        }

        protected Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = adress;
            _id = id;
        }

        public string _firstName { get; set; } = string.Empty;
        public string _lastName { get; set; } = string.Empty;
        public string _address { get; set; } = string.Empty;
        public int _id { get; set; } = 0;

        public virtual void Display()
        {
            Console.Write($"{_firstName} {_lastName} details: ");
            Console.Write($"Address: {_address}; ID: {_id}.");
        }
    }
}
