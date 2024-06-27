using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class UC_load : UserControl
    {
        string _day, date, weekday;
        public UC_load(string day)
        {
            InitializeComponent();
            _day = day;
            lblDays.Text = day;
            chb.Hide();

        }

        private void UC_Load_1(object sender, EventArgs e)
        {

        }
        private void ShowDays(int month, )
        {

        }
    }
}
