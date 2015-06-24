using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network.TransferFunctions
{
    
    public interface ITransferFunction
    {
        double Calculate(double netInput, double k=1);
        double Derivative(double a);
    }
}
