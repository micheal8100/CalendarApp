﻿using System;
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
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        public void SetEventLable(string even)
        {
            lblEventHolder.Text = even;
        }
    }
}
