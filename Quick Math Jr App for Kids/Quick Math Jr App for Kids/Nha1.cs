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
            btnNha2 nha2 = new btnNha2();
            nha2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
