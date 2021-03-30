using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MP2.Models.InputManager;

namespace MP2.Models
{
    public class TrainData
    {
        public string OutputAttribute { get; set; }
        public string[] InputAttributes { get; set; }
        public float LearningRate { get; set; }
        public uint Epoch { get; set; }
        public Perceptron @Perceptron { get; set; }
        public Predicate<Attribute> @Predicate { get; set; }
        public DataSet @DataSet { get; set; }
        public DataType OutputDataType { get; set; }

        public void TransformData(out double[][] input, out double[] output)
        {
            List<double[]> inputs = new List<double[]>();
            List<double> outputs = new List<double>();
            InputManager.dataSets.TryGetValue(@DataSet, out List<UniversalObject> objects);

            foreach (var item in objects)
            {
                //input
                var inputKeys = item.DoubleValues.Where(k => InputAttributes.Contains(k.Key)).ToArray();
                List<double> inputList = new List<double>();
                foreach (var key in inputKeys)
                {
                    inputList.Add(key.Value);
                }
                inputs.Add(inputList.ToArray());
                //

                //output
                object value = null;
                switch (OutputDataType)
                {
                    case DataType.DOUBLE:
                        value = item.DoubleValues.Single(k => k.Key == OutputAttribute).Value;
                        break;
                    case DataType.STRING:
                        value = item.StringValues.Single(k => k.Key == OutputAttribute).Value;
                        break;
                    default:
                        throw new ArgumentNullException($"Data type <{OutputDataType}> was not implemented in MainController :: DataTransformer");
                }
                outputs.Add(@Predicate.Invoke(new Attribute("atr", value.ToString())) ? 1 : 0);
                //

            }

            input = inputs.ToArray();
            output = outputs.ToArray();
        }
    }
}
