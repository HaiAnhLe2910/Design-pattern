using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_DPR
{
    public partial class Form1 : Form
    {
        DuckDetails duck;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfor_Click(object sender, EventArgs e)
        {
            if (rbDuck.Checked)
                duck = new DuckDetails(new PlasticDuck());
            else if (rbBird.Checked)
                duck = new DuckDetails(new SparrowAdapter(new Sparrow()));
            else if (rbFish.Checked)
                duck = new DuckDetails(new DolphinAdapter(new Dolphin()));
            lbSqueakSound.Text = duck.GetSqueakSound();
            lbFlyWay.Text = duck.GetFlyMethod();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
