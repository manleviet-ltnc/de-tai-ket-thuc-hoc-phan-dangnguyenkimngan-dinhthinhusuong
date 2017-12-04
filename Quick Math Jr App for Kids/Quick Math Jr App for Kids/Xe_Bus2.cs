using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Math_Jr_App_for_Kids
{
    public partial class Xe_Bus2 : Form
    {
        public Xe_Bus2()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Xe_Bus3 xebus = new Xe_Bus3();
            xebus.Show();
            this.Close();
        }
    }
}
