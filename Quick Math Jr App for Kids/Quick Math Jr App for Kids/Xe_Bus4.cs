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
    public partial class Xe_Bus4 : Form
    {
        public Xe_Bus4()
        {
            InitializeComponent();
        }

        private void Xe_Bus4_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
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

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            Button pb = (Button)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;

            pictureBox6.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox6.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox6.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox7.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox7.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox7.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox8.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox8.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox8.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Xe_Bus5 xebus = new Xe_Bus5();
            xebus.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xe_Bus3 lv3 = new Xe_Bus3();
            lv3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
