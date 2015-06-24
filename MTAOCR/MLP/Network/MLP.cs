using MLP.Network.TransferFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MLP.Network
{
    public delegate void UpdateUI(double Error, double Epoch);
    [Serializable]
    public class MLP
    {
        private double[] _input;
        private double[] _output;
        private double[] _target;
        private List<double> _errorEachEpoch;
        private List<double> _errorOnValidation;
        private int EpochToStop = 0;
        private double ErrorToStop = 0;
        private Settings settings;
        private double LerningRateUpStep;
        private double LerningRateDownStep;
        private int EpochPreventOverfitting;

        public UpdateUI updateUI;
        public double Momentum { get; set; }
        public double Eta { get; set; }
        public int Epoch { get; set; }
        public int ErrorThresholdPercent { get; set; }
        public double Error
        {
            get;
            private set;
            //Tính tổng bình phương sai số
            //get
            //{
            //    double err = 0;
            //    Layer output = layers.Last();
            //    for (int i = 0; i < output.neurons.Count; i++)
            //    {
            //        err +=Math.Pow(output.neurons[i].Target - output.neurons[i].a,2);
            //    }
            //    err = err * 0.5;
            //    return err;
            //}
        }
        public List<Layer> layers { get; private set; }

        public double[] ErrorEachEpoch
        {
            get
            {
                if (_errorEachEpoch == null)
                    return null;
                return _errorEachEpoch.ToArray();
            }
        }

        public double[] ErrorOnValidationData
        {
            get
            {
                return _errorOnValidation.ToArray();
            }
        }

        public MLP(Settings Configuration)
        {
            this.settings = Configuration;
            layers = new List<Layer>();
            try
            {
                this.EpochToStop = (int)Configuration["EpochToStop"];
                this.ErrorToStop = (double)Configuration["ErrorToStop"];
                this.Momentum = (double)Configuration["Momentum"];
                this.LerningRateDownStep = (double)Configuration["LearningRateDownStep"];
                this.LerningRateUpStep = (double)Configuration["LearningRateUpStep"];
                this.ErrorThresholdPercent = (int)Configuration["ErrorThresholdPercent"];
                this.EpochPreventOverfitting = (int)Configuration["EpochPreventOverfitting"];

                ITransferFunction tranferFunc = (ITransferFunction)Assembly.
                    GetExecutingAssembly().CreateInstance("MLP.Network.TransferFunctions." 
                    + Configuration["TransferFunction"]);

                int NumberOfLayers = (int)Configuration["NumberOfLayers"];

                for (int i = 1; i <= NumberOfLayers; i++)
                {
                    int NumberOfNeurons = (int)Configuration["NeuronsOfLayer[" + i + "]"];
                    Layer l = new Layer(NumberOfNeurons, tranferFunc);
                    this.layers.Add(l);
                }
                for (int i = 0; i < NumberOfLayers - 1; i++)
                {
                    layers[i].SetRightAdjacentLayer(layers[i + 1]);
                }
                Eta = (double)Configuration["LearningRate"];//1.0E-3; //1.0x10^-3

            }
            catch (Exception e)
            {
                throw e;
            }

            _errorEachEpoch = new List<double>();
            _errorOnValidation = new List<double>();
        }

        public void CreateNew_errorEachEpoch_errorOnValidation()
        {
            _errorEachEpoch = new List<double>();
            _errorOnValidation = new List<double>();
        }

        private void BackwardPass()
        {
            //Calculate Error and change weights for output layer
            //Parallel.For(0, layers[layers.Count - 1].neurons.Count, j =>
            //{
            for (int j = 0; j < layers[layers.Count - 1].neurons.Count; j++)
            {
                Neuron n = layers[layers.Count - 1].neurons[j];
                n.Error = n.GetTransferFunction().Derivative(n.a) * (n.Target - n.a);  //error =y'(a)(1-a) = a(1-a)(t-a)

                for (int i = 0; i < n.BackwardConnections.Count; i++)
                {
                    //  Cập nhật trọng số giữa 2 neuron lớp ẩn và lớp output với momen quán tính
                    //  W(t+1) = W(t) + momen*(W(t)-(W(t-1)) + Eta*ErrorB*OutputA
                    //  Trọng số của kết nối giữa 2 neuron AB (B thuộc lớp ẩn) ErrorB là Error của neuron B thuộc lớp output
                    // OutputA là đầu ra của neuron A thuộc lớp ẩn tuy nhiên lại chính là đầu vào của neuronB
                    n.BackwardConnections[i].Weight = n.BackwardConnections[i].Weight
                        + this.Momentum * (n.BackwardConnections[i].Weight - n.BackwardConnections[i].PreWeight)
                        + Eta * n.Error * n.BackwardConnections[i].P;

                    //Trong lúc gán Weight(t+1) đồng thời lưu lại Weight(t) vào PreWeight trong Connection.cs
                }
                //Change bias
                //
                n.Bias = n.Bias + Eta * n.Error;
            }//});

            //Calculate Error and change weights for hidden layers
            for (int i = layers.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < layers[i].neurons.Count; j++)
                {
                    //Parallel.For(0, layers[i].neurons.Count, j =>
                    //{
                        Neuron n = layers[i].neurons[j];

                        //Calculate Error
                        double E = n.GetTransferFunction().Derivative(n.a);
                        double S = 0;
                        foreach (Connection c in n.ForwardConnections)
                        {
                            S += c.Weight * c.NeuronB.Error;
                        }
                        n.Error = E * S;

                        //Change weights
                        for (int k = 0; k < n.BackwardConnections.Count; k++)
                        {
                            //
                            //  Cập nhật trọng số với momentum
                            //
                            n.BackwardConnections[k].Weight = n.BackwardConnections[k].Weight
                                + this.Momentum * (n.BackwardConnections[k].Weight - n.BackwardConnections[k].PreWeight)
                                + this.Eta * n.Error * n.BackwardConnections[k].P;
                        }

                        //Change bias
                        n.Bias = n.Bias + this.Eta * n.Error;
                        //For
                }//}); //Parallel.For
                

            }
        }

        private double GetErrorOnValidationData(List<TrainingData> validationData)
        {
            Layer output = layers.Last();
            double Error = 0;
            for (int i = 0; i < validationData.Count; i++)
            {
                output.Target = validationData[i].t;
                this.GetNetworkOutput(validationData[i].p);
                double e = 0.0;
                for (int j = 0; j < output.neurons.Count; j++)
                {
                    e += Math.Pow(output.neurons[j].Target - output.neurons[j].a, 2);
                }
                e = e * 0.5;
                Error += e;
            }
            return Error / (double)validationData.Count;
        }
        public void Training(List<TrainingData> trainingData, List<TrainingData> validationData)
        {
            int IncreaseEpoch = 0;
            double preErr = 0.0;
            double currErr = 0.0;
            while (true)
            {
                preErr = currErr;
                //this.Error = 0;
                this.Epoch++;
                if (updateUI != null)
                {
                    updateUI(this.Error, this.Epoch);
                }
                double PreError = this.Error;
                double tmpErr = 0.0;
                double[] o;
                double Ep;
                for (int i = 0; i < trainingData.Count; i++)
                {
                    this.layers[layers.Count - 1].Target = trainingData[i].t;
                     o = GetNetworkOutput(trainingData[i].p);
                    this.BackwardPass();

                    Ep = 0.0;
                    Layer output = layers.Last();
                    for (int j = 0; j < output.neurons.Count; j++)
                    {
                        Ep += Math.Pow(output.neurons[j].Target - output.neurons[j].a, 2);
                    }
                    Ep = Ep * 0.5;
                    tmpErr += Ep;
                }

                this.Error = tmpErr / (double)trainingData.Count;
                _errorEachEpoch.Add(this.Error);

                currErr = GetErrorOnValidationData(validationData);
                _errorOnValidation.Add(currErr);

                if (currErr > preErr)
                {
                    IncreaseEpoch++;
                }
                else
                {
                    IncreaseEpoch = 0;
                }
                if (this.Epoch > 5000)//EpochToStop )//|| this.Error < 0.000001)//ErrorToStop)  //sau lần chạy đầu tiên => 5000 mất hơn 2h. Sau 2h sẽ thấy tỉ lệ đúng ở testdata tăng lên 0.5%
                    break;
                //if (IncreaseEpoch > this.EpochPreventOverfitting)
                //    break;
            }
        }

        public void SetUpdateUIFunction(UpdateUI _updateUI)
        {
            this.updateUI = _updateUI;
        }

        public double[] GetNetworkOutput(double[] input)
        {
            this._input = input;
            layers[0].Input = input;
            double[] a;
            for (int i = 0; i < layers.Count-1; i++)
            {
                a = layers[i].GetLayerOutput();
                layers[i + 1].Input = a;
            }
            return layers[layers.Count-1].GetLayerOutput();
        }
    }
}
