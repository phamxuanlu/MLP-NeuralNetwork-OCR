using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.OCR.Model
{
    /// <summary>
    /// Thống kê
    /// </summary>
    public class StatisticalData
    {
        /// <summary>
        /// Ở đây là kí tự
        /// </summary>
 
        public string Name { get; set; }

        /// <summary>
        /// Tổng số kí tự
        /// </summary>
 
        public int Count { get; set; }

        /// <summary>
        /// Tổng số kí tự đúng
        /// </summary>
        public int CountCorrect { get; set; }

        /// <summary>
        /// Các file đúng
        /// </summary>
 
        public List<string> _listCorrect { get; set; }

        /// <summary>
        /// Các file sai
        /// </summary>
        public List<string> _listError { get; set; }


        public StatisticalData(string name)
        {
            this.Name = name;
            _listCorrect = new List<string>();
            _listError = new List<string>();
        }

        public double getPercentCorrect()
        {
            if (Count != 0)
            {
                return Math.Round((CountCorrect / (double)Count) * 100,2);
            }
            return 0;
        }


    }
}
