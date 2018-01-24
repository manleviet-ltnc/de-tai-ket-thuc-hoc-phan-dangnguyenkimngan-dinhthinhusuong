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
    public partial class Thuyen3 : Form
    {
        public Thuyen3()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            Thuyen4 thuyen4 = new Thuyen4();
            thuyen4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thuyen2 lv2 = new Thuyen2();
            lv2.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }
    }
}
