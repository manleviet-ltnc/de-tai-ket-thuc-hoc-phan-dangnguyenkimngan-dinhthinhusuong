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
    public partial class Xe_Bus : Form
    {
        public Xe_Bus()
        {
            InitializeComponent();
        }

        private void Xe_Bus_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void xebusBox_MouseDown(object sender, MouseEventArgs e)
        {
            Xe_Bus xb = (Xe_Bus)sender;
            xb.Select();
            //xb.DoDragDrop(xb., DragDropEffects.Copy);
        }

        private void xebusBox_DragEnter(object sender, DragEventArgs e)
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

        private void xebusBos_DragDrop(object sender, DragEventArgs e)
        {
            Xe_Bus xb = (Xe_Bus)sender;
            // xb.Icon = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
