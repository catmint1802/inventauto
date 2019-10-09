using System;
using System.Windows.Forms;

namespace InvetAuto
{
    public partial class WaitingForm : Form
    {
        WaitingManager manager;

        public WaitingForm(WaitingManager manag)
        {
            InitializeComponent();
            manager = manag;
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (manager.Finished)           
                this.Close();
        }
    }
}
