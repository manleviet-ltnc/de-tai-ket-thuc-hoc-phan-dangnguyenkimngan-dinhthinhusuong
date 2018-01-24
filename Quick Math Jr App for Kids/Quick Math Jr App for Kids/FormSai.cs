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
    public partial class btnformsai : Form
    {
        public btnformsai()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void btnchoitiep_Click(object sender, EventArgs e)
        {
            btnMat1 mang1 = new btnMat1();
            mang1.Show();
            this.Close();
        }
    }
}
