using PhoneBook;
using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectory();
            phoneBook.PutNumber("John", "1234567");
            Console.WriteLine(phoneBook.GetNumber("John"));

            phoneBook.PutNumber("Ron", "");
            Console.WriteLine(phoneBook.GetNumber("Ron"));
            phoneBook.PutNumber("Ron", "1234576");
            Console.WriteLine(phoneBook.GetNumber("Ron"));
            Console.ReadKey();
        }
    }
}
