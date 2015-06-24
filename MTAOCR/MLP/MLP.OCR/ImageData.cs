using MLP.Network;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLP.ImagePreceeding;

namespace MLP.OCR
{
    public class ImageData
    {
        public List<TrainingData> ReadFolder(string path)
        {
            List<TrainingData> data = new List<TrainingData>();

            string[] Files = Directory.GetFiles(path);
            BitmapHelper temp = null;
            foreach (string s in Files)
            {
                //TrainingData trainData = new TrainingData();
                string fileName = Path.GetFileNameWithoutExtension(s);
                string Character = fileName.Split('-')[0];
                string Font = fileName.Split('-')[2];
                byte[] bytes = Encoding.Unicode.GetBytes(Character);
                
                double[] t = new double[16];
                for (int i = 0; i < 16; i++)
                {
                    t[i] = BitHelper.GetBit(bytes[(int)i / 8], (byte)(i % 8)) ? 1 : 0;
                }
                //byte[] b = new byte[2];
                //for (int i = 0; i < t.Length; i++)
                //{
                //    b[(int)i/8] = BitHelper.SetBit(b[(int)i / 8], (byte)(i % 8), t[i] == 1.0);
                //}
                //string a = Encoding.Unicode.GetString(b);
                Bitmap bm = new Bitmap(Image.FromFile(s));

                temp = new BitmapHelper(bm);

                // threshold = 160 default
                temp.Binarization(160, true); // 
                TrainingData td = new TrainingData(temp.ToBinaryArray(), t);
                td.C = Character + Font;
                td.fileName = fileName;
                data.Add(td);

            }

            return data;
        }

    }
}
