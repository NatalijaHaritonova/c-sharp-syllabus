using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ben = new Account("Benson", 17.5);
            Console.WriteLine(ben.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
