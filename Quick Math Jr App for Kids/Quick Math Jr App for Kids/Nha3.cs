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
    public partial class btnNha3 : Form
    {
        public btnNha3()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            btnnha4 nha4 = new btnnha4();
            nha4.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnNha2 lv2 = new btnNha2();
            lv2.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }
    }
}
