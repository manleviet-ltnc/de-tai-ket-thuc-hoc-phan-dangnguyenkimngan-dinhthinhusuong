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
            Form1 trangchu = new Form1();
            trangchu.Show();
            this.Close();
        }

        private void btnNha3_Load(object sender, EventArgs e)
        {

        }
    }
}
