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
    public partial class Thuyen2 : Form
    {
        public Thuyen2()
        {
            InitializeComponent();
        }

        private void btncaudung_Click(object sender, EventArgs e)
        {
            Thuyen3 thuyen = new Thuyen3();
            thuyen.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không đúng!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thuyen1 lv1 = new Thuyen1();
            lv1.Show();
            this.Close();
        }
    }
}
