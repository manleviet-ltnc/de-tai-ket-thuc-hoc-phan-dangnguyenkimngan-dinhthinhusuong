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
    public partial class Thuyen4 : Form
    {
        public Thuyen4()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            Thuyen4 thuyen4 = new Thuyen4();
            thuyen4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thuyen3 lv3 = new Thuyen3();
            lv3.Show();
            this.Close();
        }
    }
}
