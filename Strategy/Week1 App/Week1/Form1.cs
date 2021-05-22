using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        private OperatingSystem os;
        private IDiskSchedule ds;
        private List<int> requests;
        private List<int> tempRequist;

        public Form1()
        {
            InitializeComponent();
            requests = new List<int>() { 10, 40, 35, 91, 70, 19, 67, 81,92,75 };
            tempRequist = new List<int>() { 10, 40, 35, 91, 70, 19, 67, 81, 92, 75 };

            foreach (var item in requests)
            {
                lbReadRequests.Items.Add(item);
            }

            trackBar1.Maximum = requests.Max();
            trackBar1.Value = (requests.Max()-requests.Min())/2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbFirstCome.Checked)
                ds = new FirstComeFirstServe();
            else if (rbShorstSeek.Checked)
                ds = new ShorstestSeekTimeFirst();
            else if (rbScanDisk.Checked)
                ds = new ScanDisk();
            os = new OperatingSystem(ds, requests);
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int NextRequist = os.PerformProcessingRequests(trackBar1.Value);

            if(NextRequist != -1)
            {
                lbReqProcessing.Text = NextRequist.ToString();
                requests.Remove(NextRequist);
                lbReadRequests.Items.Remove(NextRequist);
                trackBar1.Value = NextRequist;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbFirstCome_CheckedChanged(object sender, EventArgs e)
        {
            os = new OperatingSystem(new FirstComeFirstServe(), requests);
        }

        private void rbShorstSeek_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void rbShorstSeek_CheckedChanged(object sender, EventArgs e)
        {
            os = new OperatingSystem(new ShorstestSeekTimeFirst(), requests);
        }

        private void rbScanDisk_CheckedChanged(object sender, EventArgs e)
        {
            os = new OperatingSystem(new ScanDisk(), requests);
        }
    }
   
}
