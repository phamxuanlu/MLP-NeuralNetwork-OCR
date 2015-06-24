using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network.TransferFunctions
{
    [Serializable]
    public class LogSig : ITransferFunction
    {
        public double Calculate(double netInput, double k=1)
        {
            return (1.0) / (1.0 + Math.Pow(Math.E, k*(-netInput)));
        }

        public double Derivative(double a)
        {
            return a * (1 - a);
        }
    }
}
