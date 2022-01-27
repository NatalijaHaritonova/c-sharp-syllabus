namespace Exercise5
{
    internal class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public string DisplayDate()
        {
            return $"{Month}/{Day}/{Year}";
        }
    }
}
