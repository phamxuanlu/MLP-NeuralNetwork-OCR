using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.ImagePreceeding
{
    public class BitmapHelper
    {
        private Bitmap image;
        public double[] BinaryArray;
        public BitmapHelper(Bitmap bm)
        {
            this.image = (Bitmap)bm.Clone();
        }

        public Bitmap Binarization(byte th, bool setThisImage = false)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            BitmapData bmdt = image.LockBits(new Rectangle(0,0,image.Width,image.Height),
                                            ImageLockMode.ReadOnly,PixelFormat.Format24bppRgb);
            BitmapData bmdtRe = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
                                            ImageLockMode.ReadWrite,PixelFormat.Format24bppRgb);

            int offset1 = bmdt.Stride - bmdt.Width * 3;
            int offset2 = bmdtRe.Stride - bmdtRe.Width * 3;
            unsafe
            {
                byte* p = (byte*)bmdt.Scan0;
                byte* pR = (byte*)bmdtRe.Scan0;
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        byte grayscale = (byte)(0.11*p[0]+0.59*p[1]+0.3*p[2]);
                        if (grayscale >= th)
                        {
                            pR[0] = pR[1] = pR[2] = 255;
                        }
                        else
                        {
                            pR[0] = pR[1] = pR[2] = 0;
                        }
                        p += 3;
                        pR += 3;
                    }
                    p += offset1;
                    pR += offset2;
                }
            }

            image.UnlockBits(bmdt);
            result.UnlockBits(bmdtRe);
            if (setThisImage)
            {
                this.image = result;
            }
            return result;
        }

        public double[] ToBinaryArray()
        {
            double[] arr = new double[this.image.Width*this.image.Height];
            BitmapData bmdt = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int offset = bmdt.Stride - bmdt.Width * 3;
            unsafe
            {
                byte* p = (byte*)bmdt.Scan0;
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        if (((p[0]+p[1]+p[2])/3.0) > 0)
                        {
                            arr[i * image.Width + j] = 0;
                        }
                        else
                        {
                            arr[i * image.Width + j] = 1;
                        }
                        p += 3;
                    }
                    p += offset;
                }
            }
            image.UnlockBits(bmdt);
            return arr;
        }
    }
}
