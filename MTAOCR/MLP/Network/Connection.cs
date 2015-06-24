using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLP.Network
{
    [Serializable]
    public class Connection
    {
        private double _Weight;

        public Neuron NeuronA{get;set;}
        public Neuron NeuronB{get;set;}
        public double Weight {
            get 
            { 
                return _Weight; 
            }
            
            set 
            {
                this.PreWeight = _Weight;
                _Weight = value;
            }
        }

        /// <summary>
        /// weight at time (t-1)
        /// </summary>
        public double PreWeight { get; set; }

        /// <summary>
        /// Giá trị đầu vào P
        /// </summary>
        public double P { get; set; }

        public Connection(Neuron A, Neuron B, double W, double P)
        {
            this.NeuronA = A;
            this.NeuronB = B;
            this.Weight = W;
            this.PreWeight = W;
            this.P = P;
        }

        public Connection() 
        {
 
        }

        public double GetConnectionValue()
        {
            return P * Weight;
        }
    }
}
