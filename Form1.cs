using System.Globalization;

namespace CalendarApp
{
    public partial class Calnedar : Form
    {
        static int _month, _year;
        public Calnedar()
        {
            InitializeComponent();
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //sets all the panels in FLP day contain. sets the month text box 
        private void ShowDays(int month, int year)
        {
            FLPDayContainer.Controls.Clear();
            _year = year;
            _month = month;

            //get the name of the month
            String monthName = new DateTimeFormatInfo().GetMonthName(month);

            //set the month textbox to month name + year
            lblMonth.Text = monthName.ToUpper() + "  " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            //adds planke panels until the staring day of the week
            for (int i = 1; i < week; i++)
            {
                UC_Day uc = new UC_Day("");
                FLPDayContainer.Controls.Add(uc);
            }
            //adds accural panels for every day of the month
            for (int i = 1; i <= day; i++)
            {
                UC_Day uc = new UC_Day(i + "");
                FLPDayContainer.Controls.Add(uc);
            }

        }
        //Pervius button
        private void ptbPervious_Click(object sender, EventArgs e)
        {
            //decrease the month
            _month--;
            //if less then 1 set month to 12 and trun back the year by 1
            if (_month < 1)
            {
                _year--;
                _month = 12;
            }
            //rerun the ShowDays camand with new month and year values
            ShowDays(_month, _year);
        }
        //Next button
        private void ptbNext_Click(object sender, EventArgs e)
        {
            //increases the month
            _month ++;
            //if moonth is greater then 12 set month to 1 and year increases by 1
            if (_month >12)
            {
                _year++;
                _month = 1;
            }
            //rerun the ShowDays camand with new month and year values
            ShowDays(_month,_year);
        }
    }
}
