using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.OCR
{
    public class BitHelper
    {
        public static bool GetBit(byte data, byte position)
        {
            return (data & (byte)(1 << position)) != 0;
        }

        public static byte SetBit(byte data, byte position, bool value)
        {
            byte mask = (byte)(1 << position);
            if (value)
            {
                return (byte)(data | mask);
            }
            else
            {
                return (byte)(data & ~mask);
            }
        }
    }
}
