/*
 *  Lớp Matrix2D lưu trữ một ma trận 2 chiều giá trị double
 *  Hỗ trợ các phép toán trên ma trận cộng trừ nhân so sánh bằng
 *  Dùng để lưu trọng số và đầu vào của Mạng Perceptron 1 lớp. 
 *  Không dùng trong MLP
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network
{
    public class Matrix2D : ICloneable, IEquatable<Matrix2D>
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        private double[,] Values;

        public Matrix2D(int _rows, int _cols)
        {
            Rows = _rows;
            Cols = _cols;
            Values = new double[_rows, _cols];
        }

        public double getValueXY(int x, int y)
        {
            return Values[x, y];
        }

        public Matrix2D getRow(int ith)
        {
            Matrix2D m = new Matrix2D(1, Cols);
            for (int i = 0; i < Cols; i++)
                m.setValueXY(0, i, getValueXY(ith, i));
            return m;
        }
        public void setValueXY(int x, int y, double value)
        {
            Values[x, y] = value;
        }


        public static Matrix2D operator *(Matrix2D a, double b)
        {
            Matrix2D c = new Matrix2D(a.Rows, a.Cols);
            for (int i = 0; i < c.Rows; i++)
            {
                for (int j = 0; j < c.Cols; j++)
                {
                    c.setValueXY(i, j, a.getValueXY(i, j) * b);
                }
            }

            return c;
        }

        public static Matrix2D operator *(double b, Matrix2D a)
        {
            return a * b;
        }

        public static Matrix2D operator +(Matrix2D a, Matrix2D b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new Exception("2 ma tran ko cung cap");
            Matrix2D c = new Matrix2D(a.Rows, a.Cols);
            for (int i = 0; i < c.Rows; i++)
            {
                for (int j = 0; j < c.Cols; j++)
                {
                    c.setValueXY(i, j, a.getValueXY(i, j) + b.getValueXY(i, j));
                }
            }

            return c;
        }

        public static Matrix2D operator *(Matrix2D a, Matrix2D b)
        {
            if (a.Cols != b.Rows)
                throw new Exception("2 ma tran khong tuong thich.");

            Matrix2D c = new Matrix2D(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    double t = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        t += a.getValueXY(i, k) * b.getValueXY(k, j);
                    }
                    c.setValueXY(i, j, t);
                }
            }

            return c;
        }

        public static Matrix2D operator -(Matrix2D a, Matrix2D b)
        {
            Matrix2D c = -1 * b;
            return a + c;
        }

        /// <summary>
        /// Ma trận chuyển vị
        /// </summary>
        /// <returns>Ma trận chuyển vị của ma trận A</returns>
        public Matrix2D T()
        {
            Matrix2D r = new Matrix2D(Cols, Rows);
            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    r.setValueXY(i, j, getValueXY(j, i));
                }
            }
            return r;
        }

        /// <summary>
        /// Khởi tạo giá trị ngẫu nhiên cho các phần tử của ma trận
        /// </summary>
        /// <param name="max">Giá trị ngẫu nhiên cho các phần tử nằm trong khoảng 0->max</param>
        public void Random(int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    setValueXY(i, j, (double)(r.Next(min * 10, max * 10)) / 10.0);
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    s += String.Format("{0,5}", getValueXY(i, j));// +"  ";
                }
                s += "\n";
            }
            return s;
        }
        public object Clone()
        {
            Matrix2D m = new Matrix2D(Rows, Cols);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    m.setValueXY(i, j, getValueXY(i, j));
                }
            }
            return m;
        }

        public bool Equals(Matrix2D other)
        {
            if (other == null)
                return false;
            if (Rows != other.Rows || Cols != other.Cols)
                return false;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (getValueXY(i, j) != other.getValueXY(i, j))
                        return false;
                }
            }

            return true;
        }
    }
}
