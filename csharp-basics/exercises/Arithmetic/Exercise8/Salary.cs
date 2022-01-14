using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Salary
    {
        public double TotalPay(double pay, int hoursWorked)
        {
            double minPay = 8.00;
            double basePay = hoursWorked * pay;

            if (pay < minPay)
            {
                throw new Exception("Error - Pay per hour is too low");
            }

            if (hoursWorked > 40 && hoursWorked < 60)
            {
                int maxHours = 40;
                double basePay40 = maxHours * pay;
                double overTime = (hoursWorked - maxHours) * 1.5 * pay;
                double totalPay = overTime + basePay40;
                return totalPay;
            }
            else if (hoursWorked > 60)
            {
                throw new Exception("Error - Employee worked too many hours");
            }
            else
            {
                return basePay;
            }
        }
    }
}
