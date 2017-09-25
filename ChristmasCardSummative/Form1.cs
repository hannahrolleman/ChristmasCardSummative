using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            Refresh();

            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            BackColor = Color.CadetBlue;
            formGraphics.FillEllipse(drawBrush, 223, 125, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 167, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 116, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 206, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 246, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 40, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 265, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 48, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 95, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 196, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 171, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 133, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 206, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 61, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 106, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 160, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 84, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 288, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 86, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 192, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 78, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 207, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 83, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 164, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 179, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 32, 15, 15);


        }
    }
    
}
