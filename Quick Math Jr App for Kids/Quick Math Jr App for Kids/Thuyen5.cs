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
    public partial class Thuyen5 : Form
    {
        public Thuyen5()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            btnformchinh thuyen5 = new btnformchinh();
            thuyen5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thuyen4 lv4 = new Thuyen4();
            lv4.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
