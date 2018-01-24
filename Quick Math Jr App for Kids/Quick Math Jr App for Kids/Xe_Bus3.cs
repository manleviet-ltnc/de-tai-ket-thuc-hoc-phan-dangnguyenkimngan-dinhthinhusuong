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
    public partial class Xe_Bus3 : Form
    {
        public Xe_Bus3()
        {
            InitializeComponent();
        }

        private void Xe_Bus3_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            pictureBox9.AllowDrop = true;
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            Button pb = (Button)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            pictureBox8.AllowDrop = true;
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;

            pictureBox1.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox1.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox1.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

            pictureBox2.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox2.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox2.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

            pictureBox3.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox3.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox3.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

            pictureBox4.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox4.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox4.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

            pictureBox5.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox5.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox5.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

            pictureBox6.MouseDown += new MouseEventHandler(pictureBox9_MouseDown);
            pictureBox6.DragEnter += new DragEventHandler(pictureBox9_DragEnter);
            pictureBox6.DragDrop += new DragEventHandler(pictureBox9_DragDrop);

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Xe_Bus4 xebus = new Xe_Bus4();
            xebus.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Xe_Bus2 lv2 = new Xe_Bus2();
            lv2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
