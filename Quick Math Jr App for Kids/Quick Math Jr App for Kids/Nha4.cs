﻿using System;
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
    public partial class btnnha4 : Form
    {
        public btnnha4()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
                btnnha5 nha5 = new btnnha5();
                nha5.Show();
                this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnNha3 lv3 = new btnNha3();
            lv3.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }
    }
}
