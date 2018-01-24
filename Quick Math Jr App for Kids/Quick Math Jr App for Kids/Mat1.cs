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
    public partial class btnMat1 : Form
    {
        public btnMat1()
        {
            InitializeComponent();
        }

        //int index;
        //int[] ListIndexDaDung;
        //int indexdadung;

        private void btncaudung_Click(object sender, EventArgs e)
        {
            //ListIndexDaDung = new int[3];
            btnMat2 mat2 = new btnMat2();
            mat2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
