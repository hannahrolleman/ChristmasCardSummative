using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ChristmasCardSummative
    //Hannah Rolleman, September 27 
    //the following code is an interactive christmas card that makes it snow, then flash "Merry Christmas" and plays jingle bells
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            //changes background image to create the sky
            BackgroundImage = null;
            Refresh();

            //creates graphics for the snow 
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //makes it snow
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

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 165, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 207, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 156, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 246, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 286, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 80, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 305, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 88, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 170, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 236, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 211, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 173, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 246, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 101, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 146, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 160, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 84, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 288, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 86, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 192, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 118, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 123, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 204, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 219, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 72, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 205, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 247, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 196, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 286, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 326, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 120, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 345, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 128, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 210, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 276, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 251, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 213, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 286, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 141, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 186, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 200, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 124, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 328, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 126, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 232, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 158, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 287, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 163, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 244, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 259, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 112, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 245, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 287, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 236, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 326, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 366, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 160, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 385, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 168, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 250, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 316, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 291, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 253, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 326, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 181, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 226, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 240, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 164, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 368, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 166, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 272, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 198, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 327, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 203, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 284, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 299, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 152, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 285, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 327, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 276, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 366, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 406, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 200, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 425, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 208, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 290, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 356, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 331, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 293, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 366, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 221, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 266, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 280, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 204, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 448, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 206, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 312, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 238, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 367, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 243, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 324, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 339, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 192, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 325, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 367, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 316, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 406, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 446, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 240, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 465, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 248, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 330, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 396, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 371, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 333, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 406, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 261, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 306, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 320, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 244, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 488, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 246, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 352, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 278, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 407, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 283, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 364, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 379, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 232, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            formGraphics.FillEllipse(drawBrush, 223, 325, 15, 15);
            formGraphics.FillEllipse(drawBrush, 156, 367, 15, 15);
            formGraphics.FillEllipse(drawBrush, 98, 316, 15, 15);
            formGraphics.FillEllipse(drawBrush, 244, 406, 15, 15);
            formGraphics.FillEllipse(drawBrush, 184, 446, 15, 15);
            formGraphics.FillEllipse(drawBrush, 241, 280, 15, 15);
            formGraphics.FillEllipse(drawBrush, 325, 465, 15, 15);
            formGraphics.FillEllipse(drawBrush, 46, 288, 15, 15);
            formGraphics.FillEllipse(drawBrush, 84, 330, 15, 15);
            formGraphics.FillEllipse(drawBrush, 116, 396, 15, 15);
            formGraphics.FillEllipse(drawBrush, 359, 371, 15, 15);
            formGraphics.FillEllipse(drawBrush, 103, 333, 15, 15);
            formGraphics.FillEllipse(drawBrush, 45, 406, 15, 15);
            formGraphics.FillEllipse(drawBrush, 164, 261, 15, 15);
            formGraphics.FillEllipse(drawBrush, 55, 306, 15, 15);
            formGraphics.FillEllipse(drawBrush, 185, 320, 15, 15);
            formGraphics.FillEllipse(drawBrush, 132, 284, 15, 15);
            formGraphics.FillEllipse(drawBrush, 99, 488, 15, 15);
            formGraphics.FillEllipse(drawBrush, 50, 286, 15, 15);
            formGraphics.FillEllipse(drawBrush, 333, 352, 15, 15);
            formGraphics.FillEllipse(drawBrush, 149, 278, 15, 15);
            formGraphics.FillEllipse(drawBrush, 287, 407, 15, 15);
            formGraphics.FillEllipse(drawBrush, 323, 323, 15, 15);
            formGraphics.FillEllipse(drawBrush, 300, 364, 15, 15);
            formGraphics.FillEllipse(drawBrush, 269, 379, 15, 15);
            formGraphics.FillEllipse(drawBrush, 133, 272, 15, 15);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.CadetBlue);

            //plays jingle bells
            SoundPlayer player = new SoundPlayer(Properties.Resources.bells);
            player.Play();

            //creates graphics for the text
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 20, FontStyle.Bold);
            drawBrush.Color = Color.Red;

            //Flashes the text
            fg.DrawString("Merry Christmas!!", drawFont, drawBrush, 75, 100);

            Thread.Sleep(1000);
            drawBrush.Color = Color.Green;

            fg.DrawString("Merry Christmas!!", drawFont, drawBrush, 75, 100);

            Thread.Sleep(1000);
            drawBrush.Color = Color.White;

            fg.DrawString("Merry Christmas!!", drawFont, drawBrush, 75, 100);

            Thread.Sleep(1000);
            drawBrush.Color = Color.Red;

            fg.DrawString("Merry Christmas!!", drawFont, drawBrush, 75, 100);

            Thread.Sleep(1000);
            drawBrush.Color = Color.Green;

            fg.DrawString("Merry Christmas!!", drawFont, drawBrush, 75, 100);

            Thread.Sleep(1000);
            drawBrush.Color = Color.White;

            //plays "Merry Christmas"
            SoundPlayer merry = new SoundPlayer(Properties.Resources.christmas);
            merry.Play();
        }
    }
    
}
