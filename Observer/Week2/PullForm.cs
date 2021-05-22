using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class PullForm : Form,IObserverPull
    {
        //Store the Subject which is going to notify this when there is an update with the data.
        WeatherDataSubject subject;

        //Constructor
        public PullForm(WeatherDataSubject subject)
        {
            InitializeComponent();

            //Store the subject.
            this.subject = subject;

            //subscribe this object to subject.
            subject.Attach(this);
        }

        //To display the new data.
        //This method will execute when the subject has an update.
        public void UpdateData()
        {
            listBox1.Items.Clear();

            //Call the subject and get the updated data. 
            float[] data = subject.GetMeasurementData();

            //Display the updated data.
            listBox1.Items.Add("Temperature: " + data[0]);
            listBox1.Items.Add("Humidity: " + data[1]);
            listBox1.Items.Add("Pressure: " + data[2]);

        }

        private void PullForm_Load(object sender, EventArgs e)
        {

        }
 
    }
}
