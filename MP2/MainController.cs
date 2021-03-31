using Exporter.Models;
using MP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MP2.Models.InputManager;
using Attribute = MP2.Models.Attribute;

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

        public static void TrainSession(TrainingParameters data)
        {
            Trainer trainer = new Trainer();
            data.TransformData(out double[][] inputs, out double[] outputs);
            trainer.Train(inputs, outputs, data.LearningRate, data.Epoch, data.Perceptron);
        }

        public static void TestSession(TrainingParameters data, out int correctCount, out int incorrectCount, out float accuracy, out string summary)
        {
            data.TransformData(out double[][] inputs, out double[] outputs);

            float correct = 0;
            float incorrect = 0;
            string summaryTmp = "";

            for (int i = 0; i < inputs.Length; i++)
            {
                var res = data.Perceptron.GetOutput(new Vector(inputs[i]));
                if (res == outputs[i]) correct++;
                else incorrect++;
                summaryTmp += $"GivenInput: [{string.Join(", ", inputs[i])}]\r\nWantedResult: {outputs[i]}\r\nActualResult: {res}\r\n\r\n";
            }

            correctCount = (int)correct;
            incorrectCount = (int)incorrect;
            accuracy = ((int)((correct / (correct + incorrect)) * 100));
            summary = summaryTmp;
        }

        public static Predicate<Attribute> CreatePredicate(string @operator, string value)
        {
            Predicate<Attribute> predicate;
            var asd = new Attribute("test", value);
            
            switch (@operator)
            {
                case "==":
                    return predicate = o1 => o1.value == asd.value;
                case "!=":
                    return predicate = o1 => o1.value != asd.value;
                case ">":
                    return predicate = o1 => o1.value > asd.value;
                case "<":
                    return predicate = o1 => o1.value < asd.value;
            }
            return null;
        }
    }
}
