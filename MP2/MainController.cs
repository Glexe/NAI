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
            while ((line = parser.ParseLine()) != null)
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

        public static bool TestOnce(Perceptron perceptron, double[] input, double output)
        {
            return perceptron.GetOutput(input) == output;
        }

        public static int GetOutput(Perceptron perceptron, double[] input)
        {
            return perceptron.GetOutput(input);
        }

        public static void TrainSession(TrainData data)
        {
            Trainer trainer = new Trainer();
            data.TransformData(out double[][] inputs, out double[] outputs);
            trainer.Train(inputs, outputs, data.LearningRate, data.Epoch, data.Perceptron);
        }

        public static string TestSession(TrainData data)
        {
            data.TransformData(out double[][] inputs, out double[] outputs);

            float correct = 0;
            float incorrect = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (data.Perceptron.GetOutput(inputs[i]) == outputs[i]) correct++;
                else incorrect++;
            }

            float accuracy = correct / (correct + incorrect);
            return $"Correct: {correct} \r\nIncorrect: {incorrect} \r\nAccuracy: {accuracy}";
        }
    }
}
