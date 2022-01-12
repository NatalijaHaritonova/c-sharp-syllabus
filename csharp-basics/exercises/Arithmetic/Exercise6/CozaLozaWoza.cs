namespace Exercise6
{
    public class CozaLozaWoza
    {
        public string CozaLozaWozaNumCheck(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "CozaLoza ";
            }
            else if (num % 3 == 0 && num % 7 == 0)
            {
                return "CozaWoza ";
            }
            else if (num % 5 == 0 && num % 7 == 0)
            {
                return "LozaWoza ";
            }
            else if (num % 5 == 0)
            {
                return "Loza ";
            }
            else if (num % 7 == 0)
            {
                return "Woza ";
            }
            else if (num % 3 == 0)
            {
                return "Coza ";
            }
            else
            {
                return $"{num} ";
            }
        }
    }
}
