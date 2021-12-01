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