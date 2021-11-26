using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            string a = "1";
            int convertedA = int.Parse(a);
            int b = 2;
            int c = 3;
            double d = 4;
            int convertedD = Convert.ToInt32(d);
            float e = 5;
            int convertedE = (int)e;
            //fixme - should be 15 :|
            int sum = convertedA + b + c + convertedD + convertedE;
            Console.WriteLine(sum);
        }

        static void Second()
        {
            string a = "1";
            float convertedA = float.Parse(a);
            int b = 2;
            float convertedB = (float)b;
            int c = 3;
            float convertedC = (float)c;
            double d = 4.2;
            float convertedD = (float)d;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            float sum = convertedA + convertedB + convertedC + convertedD + e;
            Console.WriteLine(sum);
        }
    }
}
