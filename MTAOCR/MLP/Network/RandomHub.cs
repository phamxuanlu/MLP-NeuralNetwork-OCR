using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network
{
    public class RandomHub
    {
        public static int MIN = -1;
        public static int MAX = 1;
        private static Random _random = new Random();
        //Debug
        //static int i = 10;
        public static double Next(double min, double max)
        {
            int _min = (int)min * 100000;
            int _max = (int)max * 100000;
            int i = 0;
            while ((i = _random.Next(_min, _max)) == 0) ;
            return i/100000.0;
        }
    }
}
