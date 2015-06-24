using MLP.ImagePreceeding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP.OCR
{
    public class MyDrawing
    {
        public static void DrawBinarization(double[] binaryArray, PictureBox pictureBox1, int W, int H)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            Bitmap nBM = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(nBM);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            
            int j = 0;
            double ratioX = pictureBox1.Width / W;
            double ratioY = pictureBox1.Height / H;
            Pen p = new Pen(Brushes.Blue, 2.0f);
            Font f = new Font("Tahoma", 1.0f);
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (i % W == 0 && i != 0)
                {
                    j++;
                }
                int RealW = i - j * W;
                if (binaryArray[i] > 0)
                {
                    g.FillRectangle(Brushes.Gray, new Rectangle((int)(RealW * ratioX), (int)(j * ratioY), (int)ratioX, (int)ratioY));
                    g.DrawString("1", f, Brushes.Blue, (int)(RealW * ratioX), (int)(j * ratioY));
                    //g.DrawRectangle(p, new Rectangle((int)(RealW * ratioX), (int)(j * ratioY), (int)ratioX, (int)ratioY));
                }
                else
                {
                    g.DrawString("0", f, Brushes.Blue, (int)(RealW * ratioX), (int)(j * ratioY));
                }
            }
            pictureBox1.Image = nBM;
        }
    }
}
