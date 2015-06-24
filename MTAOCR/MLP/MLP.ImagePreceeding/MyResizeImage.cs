using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.ImagePreceeding
{
    public class MyResizeImage
    {
        
        int[,] grayImage,character;
        private int startW ;
        private int endW;
        private int startH;
        private int endH;
        int[] intensityHeight, intensityWidth;
        public MyResizeImage(Bitmap b)
        {
            
            grayImage = Gray_ArrayInt(b);
        }

        private void getCharacter()
        {
            ReadIntensity();

            startH = startW = 0;
            endW = intensityWidth.Length ;
            endH = intensityHeight.Length ;
         

            // start Width
            for (int i = 0; i < intensityWidth.Length; i++)
            {
                if (intensityWidth[i] > 0)
                {
                    startW = i;
                    break;
                }
            }
            // end Width
            for (int i = intensityWidth.Length-1; i >0; i--)
            {
                if (intensityWidth[i] > 0)
                {
                    endW = i;
                    break;
                }
            }

            // start Height
            for (int i = 0; i < intensityHeight.Length; i++)
            {
                if (intensityHeight[i] > 0)
                {
                    startH = i;
                    break;
                }
            }
            // end Height
            for (int i = intensityHeight.Length - 1; i > 0; i--)
            {
                if (intensityHeight[i] > 0)
                {
                    endH = i;
                    break;
                }
            }

            int height = endH-startH+1;
            int width = endW-startW+1;
            character = new int[height ,width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    character[i, j] = grayImage[i+startH, j+startW];
                }
            }
        }

        public Bitmap getImage(Size size)
        {
            getCharacter();
            Bitmap b = ConvertArray2Image(character);

            return new Bitmap(b,size);
        }


        private void ReadIntensity()
        {
            int height = grayImage.GetLength(0);
            int width = grayImage.GetLength(1);
            intensityHeight = new int[height];
            intensityWidth = new int[width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grayImage[i, j] !=255) 
                    {
                        intensityHeight[i]++;
                        intensityWidth[j]++;
                    }
                }
            }
            

        }

        private int[,] Gray_ArrayInt(Bitmap bit_map)
        {
            int[,] imageGray = new int[bit_map.Height, bit_map.Width];

            BitmapData bit_map_data_1 = bit_map.LockBits(new Rectangle(0, 0, bit_map.Width, bit_map.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);



            unsafe
            {

                byte* ptr1 = (byte*)bit_map_data_1.Scan0;
                int offset = bit_map_data_1.Stride - bit_map_data_1.Width * 3;
                for (int i = 0; i < bit_map_data_1.Height; i++)
                {
                    for (int j = 0; j < bit_map_data_1.Width; j++)
                    {
                        imageGray[i, j] = (byte)((ptr1[0] + ptr1[1] + ptr1[2]) / 3);

                        ptr1 += 3;
                    }
                    ptr1 += offset;
                }
            }
            bit_map.UnlockBits(bit_map_data_1);
            return imageGray;


        }
        private  Bitmap ConvertArray2Image(int[,] data)
        {
            int height = data.GetLength(0);
            int width = data.GetLength(1);
            byte temp;
            Bitmap bit_map_2 = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bit_map_data_2 = bit_map_2.LockBits(new Rectangle(0, 0, bit_map_2.Width, bit_map_2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* ptr2 = (byte*)bit_map_data_2.Scan0;
                int offset = bit_map_data_2.Stride - bit_map_data_2.Width * 3;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (data[i, j] >= 255)
                            temp = 255;
                        else
                        {
                            if (data[i, j] <= 0)
                                temp = 0;
                            else temp = (byte)(data[i, j] & 255);
                        }
                        ptr2[i * bit_map_data_2.Stride + j * 3] = temp;
                        ptr2[i * bit_map_data_2.Stride + j * 3 + 1] = temp;
                        ptr2[i * bit_map_data_2.Stride + j * 3 + 2] = temp;
                        // ptr2 += 3;

                    }
                    //ptr2 += offset;
                }
            }
            bit_map_2.UnlockBits(bit_map_data_2);
            return bit_map_2;
        }
    }
}
