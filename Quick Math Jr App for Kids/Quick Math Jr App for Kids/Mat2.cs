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
    public partial class btnMat2 : Form
    {
        public btnMat2()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
                btnMat3 mat3 = new btnMat3();
                mat3.Show();
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng");
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnMat1 lv1 = new btnMat1();
            lv1.Show();
            this.Close();
        }
    }
}
