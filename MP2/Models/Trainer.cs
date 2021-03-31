using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2.Models
{
    public class Trainer
    {
        private double[][] _inputs;
        private List<double[]> _inputVectors;
        private double[] _wantedOutputs;

        private Perceptron _perceptron;
        private double[] _tempWeights;
        private float _learningRate;

        private double _totalError;

        public void Train(double[][] inputData, double[] outputs, float learningRate,  uint epoch, Perceptron perceptron)
        {
            _inputs = inputData;
            _wantedOutputs = outputs;
            _learningRate = learningRate;
            _perceptron = perceptron;
            _perceptron.ResizeWeights(inputData[0].Length);
            _tempWeights = _perceptron.Weights;
            _totalError = 0;

            for(int i=0; i<epoch; i++)
            {
                RunOnce();
                if (_totalError == 0) break;
            }
        }

        private void PrepareInputData()
        {
            _inputVectors = new List<double[]>();
            if (_inputs is null) return;
            foreach (var item in _inputs)
            {
                _inputVectors.Add(new Vector(item).Normalized());
            }
        }

        private void RunOnce()
        {
            PrepareInputData();
            for(int i=0; i<_wantedOutputs.Length; i++)
            {
                int actualOutput = _perceptron.GetOutput(_inputVectors[i]);
                double error = (_wantedOutputs[i] - actualOutput);
                _totalError += error;

                for(int x=0; x<_tempWeights.Length; x++)
                {
                    double delta = _learningRate * _inputVectors[i][x] * error;
                    _tempWeights[x] += delta;
                }
            }

            _perceptron.Weights = _tempWeights;
        }
    }
}
