/*
Use several variables to store the names of your classes and their teachers. Then, display a nice little table
displaying your schedule. FYI, my column of courses has a width of 26 characters, and the teacher column has a
width of 15. The first and last lines are a plus sign, fifty dashes (a.k.a. minus signs) and another plus sign.

Your table doesn't need to look exactly like this, or even line up.
+------------------------------------------------------------+
| 1 |                          English III |       Ms. Lapan |
| 2 |                          Precalculus |     Mrs. Gideon |
| 3 |                         Music Theory |       Mr. Davis |
| 4 |                        Biotechnology |      Ms. Palmer |
| 5 |           Principles of Technology I |      Ms. Garcia |
| 6 |                             Latin II |    Mrs. Barnett |
| 7 |                        AP US History | Ms. Johannessen |
| 8 | Business Computer Infomation Systems |       Mr. James |
+------------------------------------------------------------+


*/
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int t, i;
            string[,] table = new string[8, 3];
            for (t = 0; t < 8; t++) 
            {
                for (i = 0; i < 3; i++) 
                {
                    string[] indexNum = { "1", "2", "3", "4", "5", "6", "7", "8" };
                    string[] teachers = { "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia",
                        "Mrs. Barnett", "Ms. Johannessen", "Mr. James" };
                    string[] subject = { "English III", "Precalculus", "Music Theory", "Biotechnology",
                        "Principles of Technology I", "Latin II", "AP US History",
                        "Business Computer Infomation Systems" };
                    if (i == 0) 
                    {
                        table[t, i] = indexNum[t];
                        Console.Write("|" + table[t, i] + "|" + "     ");
                    }
                    else if (i == 1)
                    {
                        table[t, i] = subject[t];
                        Console.Write("|" + table[t, i] + "|" + "     ");
                    }
                    else if (i == 2) 
                    {
                        table[t, i] = teachers[t];
                        Console.Write("|" + table[t, i] + "|" + "     ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}