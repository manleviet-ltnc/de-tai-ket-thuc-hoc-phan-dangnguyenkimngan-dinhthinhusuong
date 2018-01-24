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
    public partial class Xe_Bus2 : Form
    {
        public Xe_Bus2()
        {
            InitializeComponent();
        }

        private void Xe_Bus2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
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
        private void Level2_Click(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;

            pictureBox9.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox9.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox9.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox10.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox10.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox10.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox11.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox11.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox11.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox12.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox12.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox12.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            pictureBox13.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox13.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox13.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

        }
        private void Next_Click(object sender, EventArgs e)
        {
            Xe_Bus3 xebus = new Xe_Bus3();
            xebus.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xe_Bus1 lv1 = new Xe_Bus1();
            lv1.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnformchinh form = new btnformchinh();
            form.Show();
            this.Close();
        }
    }
}
