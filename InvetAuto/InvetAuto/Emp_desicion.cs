using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvetAuto
{
    public partial class Emp_desicion : Form
    {
        public Emp_desicion()
        {
            InitializeComponent();
        }

        private void Btn_transfer_Click(object sender, EventArgs e)
        {
            emp.status = 1;
            //this.Close();
        }

        private void Btn_relocation_Click(object sender, EventArgs e)
        {
            emp.status = 2;
            //this.Close();
        }

        private void Btn_fired_Click(object sender, EventArgs e)
        {
            emp.status = 3;
            this.Close();
        }
    }
}
