using MLP.Network.TransferFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Network
{
    [Serializable]
    public class Layer
    {
        private double[] _input;
        private double[] _target;
        public List<Neuron> neurons{get;private set;}
        public double[] Input{
            get { return this._input; }
            set { SetInput(value); }
        }

        /// <summary>
        /// target
        /// </summary>
        public double[] Target{
            get{return this._target;}
            set{SetTarget(value);}
        }
        public double[] Output { get; private set; }

        public Layer(int NumberOfNeurons, ITransferFunction func)
        {
            neurons = new List<Neuron>();
            for (int i = 0; i < NumberOfNeurons; i++)
            {
                Neuron n = new Neuron();
                n.SetTransferFunction(func);
                neurons.Add(n);
            }
            Output = new double[NumberOfNeurons];
        }

        private void SetInput(double[] val)
        {
            if (val == null)
                throw new Exception("Input = null");
            else
                _input = val;

            //Nếu neuron đã có sẵn các kết nối thì cập nhật lại đầu vào input P của các kết nối
            if (this.neurons[0].BackwardConnections.Count != 0)
            {
                for (int i = 0; i < neurons.Count; i++)
                {
                    for (int j = 0; j < val.Length; j++)
                    {
                        this.neurons[i].BackwardConnections[j].P = val[j];
                    }
                }
            }
            else //Ngược lại tạo các kết nối mới với các đầu vào P
            {
                for (int i = 0; i < neurons.Count; i++)
                {
                    for (int j = 0; j < val.Length; j++)
                    {
                        Connection c = new Connection(null, neurons[i], RandomHub.Next(RandomHub.MIN, RandomHub.MAX), val[j]);
                        neurons[i].AddConnections(c);
                    }
                }
            }
        }

        private void SetTarget(double[] target)
        {
            this._target = target;
            if (target.Length != neurons.Count)
            {
                throw new Exception("Kích thước vecto Target khác số neuron lớp output");
            }

            for (int i = 0; i < neurons.Count; i++)
            {
                neurons[i].Target = target[i];
            }
        }

        public void SetRightAdjacentLayer(Layer al)
        {
            for (int i = 0; i < al.neurons.Count; i++)
            {
                al.neurons[i].AddConnections(this.neurons);
            }
        }

        public double[] GetLayerOutput()
        {
            for (int i = 0; i < neurons.Count; i++)
            {
                Output[i] = neurons[i].GetOutput();
            }
            //Parallel.For(0, neurons.Count, i =>
            //{
            //    Output[i] = neurons[i].GetOutput();
            //});
            return Output;
        }
    }
}
