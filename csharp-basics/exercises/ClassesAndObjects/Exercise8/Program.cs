namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            SavingsAccount acc = new SavingsAccount(double.Parse(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            acc.AnnualIntRate(double.Parse(Console.ReadLine()));
            Console.Write("How long has the account been opened?: ");
            int month = int.Parse(Console.ReadLine());
            double intRateSum = 0;
            double totalDep = 0;
            double totalWith = 0;

            for (int i = 0; i < month; i++)
            {
                Console.Write("Enter amount deposited for month " + (i + 1) + ": ");
                double deposite = double.Parse(Console.ReadLine());
                totalDep += deposite;
                acc.Deposit(deposite);
                Console.Write("Enter amount withdrawn for " + (i + 1) + ": ");
                double withdraw = double.Parse(Console.ReadLine());
                totalWith += withdraw;
                acc.Withdraw(withdraw);
                double balanceBeforeMI = acc._balance;
                intRateSum += acc.MonthlyInterest() - balanceBeforeMI;
            }

            Math.Round(intRateSum, 2);
            Math.Round(totalDep, 2);
            Math.Round(totalWith, 2);

            Console.WriteLine("Total deposited: $" + totalDep.ToString("N"));
            Console.WriteLine("Total withdrawn: $" + totalWith.ToString("N"));
            Console.WriteLine("Interest earned: $" + intRateSum.ToString("N"));
            Console.WriteLine("Ending balance: $" + acc._balance.ToString("N"));
        }
    }
}
