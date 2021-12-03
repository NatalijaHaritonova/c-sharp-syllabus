namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalPay(7.5, 35);
            TotalPay(8.2, 47);
            TotalPay(10.0, 73);

            static void TotalPay(double pay, int hoursWorked) 
            {
                double minPay = 8.00;
                double basePay = hoursWorked * pay;
                
                if (pay < minPay)
                {
                    Console.WriteLine("Error - Pay per hour is too low");
                }
                else if (hoursWorked > 40 && hoursWorked < 60)
                {
                    int maxHours = 40;
                    double basePay40 = maxHours * pay;
                    double overTime = (hoursWorked - maxHours) * 1.5 * pay;
                    double totalPay = overTime + basePay40;
                    Console.WriteLine(totalPay);
                }
                else if (hoursWorked > 60)
                {
                    Console.WriteLine("Error - Employee worked too many hours");
                }
                else
                {
                    Console.WriteLine(basePay);
                }
            }
        }
    }
}
