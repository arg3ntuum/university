using System;

namespace SP_Lab_2
{
    public class Date
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public Date() {
            Day = DateTime.Now.Day;
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
        }
        public void SetDay(int value)
        {
            if (value >= 1 && value <= 31)
                Day = value;
            else
                Day = DateTime.Now.Day;
        }
        public void SetMonth(int value)
        {
            if (value >= 1 && value <= 12)
                Month = value;
            else
                Month = DateTime.Now.Month;
        }
        public void SetYear(int value) {
            if (value >= 2000 && value <= DateTime.Now.Year)
                Year = value;
            else
                Year = DateTime.Now.Year;
        }
    }
}
