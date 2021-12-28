using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("First accaunt: ");
            Console.WriteLine();
            Account bartosAcc = new Account("Barto's accaunt", 100.0);
            Console.WriteLine("Initial state");
            Console.WriteLine();
            Console.WriteLine(bartosAcc.ToString());
            bartosAcc.Deposit(20.0);
            Console.WriteLine("After deposit");
            Console.WriteLine();
            Console.WriteLine($"{bartosAcc.Name} balance is now : {bartosAcc.Balance()}");
            Console.ReadKey();

            Console.WriteLine("First money transfer: ");
            Console.WriteLine();
            Account mattsAcc = new Account("Matt's account", 1000);
            Account myAcc = new Account("My account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine();
            Console.WriteLine(mattsAcc.ToString());
            Console.WriteLine(myAcc.ToString());
            mattsAcc.Withdrawal(100);
            myAcc.Deposit(100);
            Console.WriteLine("After transfer");
            Console.WriteLine();
            Console.WriteLine($"{mattsAcc.Name} balance is now : {mattsAcc.Balance()}");
            Console.WriteLine($"{myAcc.Name} balance is now : {myAcc.Balance()}");
            Console.ReadKey();

            Console.WriteLine("Money transfers: ");
            Console.WriteLine();
            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine();
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.WriteLine();
            Transfer(A, B, 50);
            Transfer(B, C, 25);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
            Console.WriteLine($"{from.Name} balance after transfering {howMuch} to {to.Name}: {from.Balance()}");
            Console.WriteLine($"{to.Name} balance after transfering {howMuch} from {from.Name}: {to.Balance()}");
        }
    }
}
