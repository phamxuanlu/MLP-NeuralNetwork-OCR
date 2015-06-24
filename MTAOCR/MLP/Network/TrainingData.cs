using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network
{
    public class TrainingData
    {
        public double[] p { get; set; } //ma trận đầu vào input
        public double[] t { get; set; } //Đầu ra mong muốn target
        public string C { get; set; } //Ký tự

        public string fileName { get; set; }// tên file
        public TrainingData(double[] input, double[] target)
        {
            p = input;
            t = target;
        }
    }
}
