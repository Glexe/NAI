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
            ReadData(filePath, dataSet);
        }

        public static string GetOutput()
        {
            return "asd";
        }
    }
}
