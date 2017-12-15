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
    public partial class Nha1 : Form
    {
        public Nha1()
        {
            InitializeComponent();
        }

        private void caudung_Click(object sender, EventArgs e)
        {
            bntNha2 nha2 = new bntNha2();
            nha2.Show();
            this.Close();
        }
    }
}
