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
    public partial class btnMat3 : Form
    {
        public btnMat3()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chúc mừng bạn đã hoàn thành");
            btnmat4 mat4 = new btnmat4();
            mat4.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnMat2 lv2 = new btnMat2();
            lv2.Show();
            this.Close();
        }
    }
}
