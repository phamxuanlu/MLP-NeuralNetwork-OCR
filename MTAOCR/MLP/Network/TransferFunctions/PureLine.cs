using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network.TransferFunctions
{
    [Serializable]
    public class PureLine : ITransferFunction
    {

        public double Calculate(double netInput, double k=1)
        {
            return netInput;
        }


        public double Derivative(double a)
        {
            throw new NotImplementedException();
        }
    }
}
