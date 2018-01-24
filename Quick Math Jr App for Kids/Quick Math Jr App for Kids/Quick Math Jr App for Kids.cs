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

        private void button2_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
        }
    }
}
