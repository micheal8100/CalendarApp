using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class UC_Day : UserControl
    {
        string _day;
        public static string staticDay = "";
        public UC_Day(string day)
        {
            InitializeComponent();
            _day = day;
            lblDays.Text = day;
        }

        private void UC_Load_1(object sender, EventArgs e)
        {

        }

        private void UC_DaysClick(object sender, EventArgs e)
        {

            staticDay = lblDays.Text;
            EventForm ev = new EventForm();
            ev.SetEventString(lblEventHolder.Text);
            ev.Show();
            //starts the timer
            tmeCheck.Start();
            //stops the timer if form has been closed
            if (ev.Visible == false)
            {
                tmeCheck.Stop();
            }
        }

        public void SetEventLable(string even)
        {
            lblEventHolder.Text = even;
        }

        //checks every tick 
        private void timCheck_tick(object sender, EventArgs e)
        {
            eventChecker();
        }
        public void eventChecker()
        {
            EventForm ev = new EventForm();
            foreach (Event even in ev.GetEvents())
            {
                //check if an event date and the date
                if (even.date == (_day + "/" + Calnedar._month + "/" + Calnedar._year))
                {
                    this.SetEventLable(even.reminder);
                }
            }
        }
    }
}
