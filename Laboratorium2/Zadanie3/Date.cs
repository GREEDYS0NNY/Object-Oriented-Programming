namespace Zadanie3
{
    internal class Date
    {
        private DateTime DateNow;

        public Date()
        {
            DateNow = DateTime.Now.Date;
        }

        public DateTime CurrentDate() { return DateNow; }

        public void AddWeek()
        {
            DateNow = DateNow.AddDays(7);
        }

        public void SubstractWeek()
        {
            DateNow = DateNow.AddDays(-7);
        }
    }
}
