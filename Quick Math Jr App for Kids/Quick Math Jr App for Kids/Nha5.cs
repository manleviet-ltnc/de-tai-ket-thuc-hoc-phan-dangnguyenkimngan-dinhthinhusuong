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
    public partial class btnnha5 : Form
    {
        public btnnha5()
        {
            InitializeComponent();
        }

        private void caudung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chúc mừng bạn đã hoàn thành!!!");
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnmat4 lv4 = new btnmat4();
            lv4.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
