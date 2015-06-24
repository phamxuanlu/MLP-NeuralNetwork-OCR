using MLP.Network.TransferFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network
{
    [Serializable]
    public class Neuron
    {
        private ITransferFunction _transferFunction;
        public double Bias { get; set; }

        //Các kết nối đến một neuron
        public List<Connection> BackwardConnections;

        //các kết nối từ một neuron đi
        public List<Connection> ForwardConnections;
        public double a { get { return GetOutput(); } } //Actual Output
        public double Target { get; set; } //Desire output
        public double Error { get; set; }
        public Neuron()
        {
            BackwardConnections = new List<Connection>();
            ForwardConnections = new List<Connection>();
            this.Bias = RandomHub.Next(RandomHub.MIN, RandomHub.MAX);
        }


        #region Initialize

        public void SetTransferFunction(ITransferFunction func)
        {
            this._transferFunction = func;
        }

        public ITransferFunction GetTransferFunction()
        {
            return this._transferFunction;
        }
        public void AddConnections(Neuron A)
        {
            Connection c = new Connection(A, this, RandomHub.Next(RandomHub.MIN, RandomHub.MAX), 0.0);
            A.ForwardConnections.Add(c);
            BackwardConnections.Add(c);
        }

        public void AddConnections(List<Neuron> neurons)
        {
            for (int i = 0; i < neurons.Count; i++)
            {
                Connection c = new Connection(neurons[i], this, RandomHub.Next(RandomHub.MIN, RandomHub.MAX), 0.0); 
                neurons[i].ForwardConnections.Add(c);
                BackwardConnections.Add(c);
            }
        }

        
        public void AddConnections(Connection c)
        {
            if (c != null)
                BackwardConnections.Add(c);
        }

        #endregion

        public double GetOutput()
        {
            double t = 0;
            //BackwardConnections.ForEach(x => { t += x.GetConnectionValue(); });
            for (int i = 0; i < BackwardConnections.Count; i++)
            {
                t += BackwardConnections[i].GetConnectionValue();
            }
            double output = _transferFunction.Calculate(t + this.Bias);
            return output;
        }

    }
}
