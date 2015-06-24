using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network.TransferFunctions
{
    [Serializable]
    public class HardLim : ITransferFunction
    {
        public double Calculate(double netInput, double k=1)
        {
            return (netInput < 0) ? 0 : 1;
        }


        public double Derivative(double a)
        {
            throw new NotImplementedException();
        }
    }
}
