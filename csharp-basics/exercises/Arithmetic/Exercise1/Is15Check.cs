namespace Exercise1
{
    public class Is15Check
    {
        public bool Is15(int num1, int num2)
        {
            return num1 == 15 || num2 == 15 || num1 + num2 == 15
                || num1 - num2 == 15 || num2 - num1 == 15;
        }
    }
}
