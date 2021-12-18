namespace Exercise5
{
    internal class Date
    {
        public int _year { get; set; }
        public int _month { get; set; }
        public int _day { get; set; }

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public string DisplayDate()
        {
            return $"{_month}/{_day}/{_year}";
        }
    }
}
