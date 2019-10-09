using System;
using System.Threading;


namespace InvetAuto
{
    public class WaitingManager : IDisposable
    {
        Thread myThread;
        WaitingForm frm;
        bool shown = false;

        public bool Finished
        {
            get;
            private set;
        }

        public WaitingManager()
        {
            Finished = false;
            myThread = new Thread(DoWork);
            myThread.Start();
        }

        void DoWork()
        {
            frm = new WaitingForm(this);
            frm.Shown += new EventHandler(frm_Shown);
            frm.ShowDialog();
        }

        void frm_Shown(object sender, EventArgs e)
        {
            shown = true;
        }

        public void Dispose()
        {
            Finished = true;
            while (!shown || frm.Visible)
                Thread.Sleep(1);
            myThread.Abort();
        }
    }
}
