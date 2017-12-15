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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);
            Text = String.Format("Quick Math Jr");
        }

        private void mnuXeBus_Click(object sender, EventArgs e)
        {
            Xe_Bus1 xebus = new Xe_Bus1();
            xebus.Show();
        }

        private void mnuNha_Click(object sender, EventArgs e)
        {
            Nha1 nha = new Nha1();
            nha.Show();
        }

        private void mnuThuyen_Click(object sender, EventArgs e)
        {
            Thuyen1 thuyen = new Thuyen1();
            thuyen.Show();
        }

        private void mnuMat_Click(object sender, EventArgs e)
        {
            btnMat1 mat = new btnMat1();
            mat.Show();
        }
    }
}
