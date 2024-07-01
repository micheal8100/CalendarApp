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
    public partial class EventForm : Form
    {
        //stores a path to find the save file
        string path = Path.Combine(Environment.CurrentDirectory, "saveFile.txt");
        //stores all events registered by the user
        List<Event> events = new List<Event>();
        public EventForm()
        {
            InitializeComponent();
        }
        public void SetEventString(string events)
        {
           
            txbEvent.Text = events;
        }
        public List<Event> GetEvents()
        {
            // runs the eserializeData() method to make sure we have the updated version.
            DeserializeData();
            return events;
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            //sets the date text box to the curent date when opened
            txbDate.Text = UC_Day.staticDay + "/" + Calnedar._month + "/" + Calnedar._year;
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            
            //creats a new event and fill in the infomation
            Event even = new Event();
            even.date = txbDate.Text;
            even.reminder = txbEvent.Text;
            //runs deserializeData
            DeserializeData();
            //check if there is already an event on the date 
            foreach(Event i in events)
            {
                if (i.date == even.date)
                {
                    events.Remove( i );
                    break;
                }
            }
            events.Add(even);
            //seralises the object events
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject( events, Newtonsoft.Json.Formatting.Indented );
            // writes to the text file in order to save data
            using (StreamWriter sw = new StreamWriter(path))
            {
                 sw.Write(serializedObject);
            }
            //shows message that event has been saved
            MessageBox.Show("Saved");
            this.Hide();
        }
        //populates the events list with all serilised data
        private void DeserializeData()
        {
            // the frist time a user runs the comanded there is no text file to at path or if its been deleted
            // this will make it crash so "try"
            try { 
                string content;
                using (StreamReader sr = new StreamReader(path))
                {
                    content = sr.ReadToEnd();
                }
                events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Event>>(content);
            }
            catch { }
        }
    }
    //a class for the event object
    public class Event {
        public string date { get; set; } 
        public string reminder {  get; set; }
    }
}
