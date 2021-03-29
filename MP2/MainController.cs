using Exporter.Models;
using MP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MP2.Models.InputManager;

namespace MP2
{
    public class MainController
    {

        public static string ReadData(string filePath, DataSet dataSet = DataSet.NONE)
        {
            var parser = new ParserCSV(filePath);
            var headers = parser.ParseHeaders();
            List<UniversalObject> objectsList = new List<UniversalObject>();

            string[] line;
            while((line = parser.ParseLine()) != null)
            {
                if (line.Length != headers.Length) throw new ArgumentException($"Invalid data in: {filePath}");
                objectsList.Add(InputManager.CreateInstance(line, headers, dataSet));
            }
            parser.Dispose();

            string data = "";
            foreach (var item in objectsList)
            {
                data += item.ToString() + "\r\n";
            }
            if (data.EndsWith("\r\n")) data = data.Substring(0, data.Length - 2);
            return data;
        }

        public static void LoadDataToDatabase(string filePath, DataSet dataSet)
        {
            InputManager.dataSets.Remove(dataSet);
            ReadData(filePath, dataSet);
        }

        public static string GetOutput()
        {
            return "asd";
        }

        public static string TestTrain(string outputName, string[] attributes, float learningRate, uint epoch, float threshold)
        {
            List<double[]> inputs = new List<double[]>();
            InputManager.dataSets.TryGetValue(DataSet.TRAIN, out List<UniversalObject> tmpList);
            List<double> outputs = new List<double>();

            List<double[]> testInputs = new List<double[]>();
            InputManager.dataSets.TryGetValue(DataSet.TEST, out List<UniversalObject> tmpTestList);
            List<double> testOutputs = new List<double>();

            foreach (var item in tmpList)
            {
                var valKeys = item.DoubleValues.Where(k => attributes.Contains(k.Key)).ToArray();

                List<double> valuesList = new List<double>();

                foreach (var key in valKeys)
                {
                    valuesList.Add(key.Value);
                }
                inputs.Add(valuesList.ToArray());

                outputs.Add(item.StringValues.Single(k => k.Key == outputName).Value == "Iris-setosa" ? 1 : 0);
            }
            
            foreach(var item in tmpTestList)
            {
                var valKeys = item.DoubleValues.Where(k => attributes.Contains(k.Key)).ToArray();

                List<double> valuesList = new List<double>();

                foreach (var key in valKeys)
                {
                    valuesList.Add(key.Value);
                }
                testInputs.Add(valuesList.ToArray());

                testOutputs.Add(item.StringValues.Single(k => k.Key == outputName).Value == "Iris-setosa" ? 1:0);
            }

            Trainer trainer = new Trainer();
            Perceptron p1 = new Perceptron(threshold);
            trainer.Train(inputs.ToArray(), outputs.ToArray(), learningRate, epoch, p1);

            float value = 0;
            float correct = 0;
            float @false = 0;

            for(int i=0; i<testInputs.Count; i++)
            {
                if (p1.GetOutput(testInputs[i]) == testOutputs[i]) correct++;
                else @false++;
            }

            value = correct / (correct + @false);
            return $"Correct: {correct} \r\n False: {@false} \r\n Opacity: {value}";
        }
    }
}
