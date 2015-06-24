using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MLP.OCR
{
    public class OpenDialogLoadImage
    {


        public static string OpenFile(string filter = "|*jpg")
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = filter;
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                return open.FileName;
            }

            return "";
        }
        public static Bitmap LoadImage(PictureBox pic, string fileName)
        {
            if (fileName != "")
            {
                Bitmap t = new Bitmap(fileName);
                pic.BackgroundImage = t;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                return t;
            }
            return null;
        }
        public static Bitmap OpenDialog(PictureBox pic)
        {
            return LoadImage(pic, OpenFile());
        }
    }
}
