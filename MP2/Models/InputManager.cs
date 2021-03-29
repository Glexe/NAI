using Exporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2.Models
{
    public static class InputManager
    {
        public static Dictionary<DataSet, List<UniversalObject>> dataSets = new Dictionary<DataSet, List<UniversalObject>>();

        public enum DataSet
        {
            NONE,
            TRAIN,
            TEST,
            OUTPUT
        }

        public enum DataType
        {
            STRING,
            DOUBLE
        }

        public static string[] GetHeaders(DataSet dataSet, DataType dataType)
        {
            if (dataSet == DataSet.NONE) return null;
            dataSets.TryGetValue(dataSet, out List<UniversalObject> tmpList);
            if (tmpList == null) return null;
            string[] headers = null;
            switch (dataType)
            {
                case DataType.STRING:
                    headers = tmpList[0].StringValues.Keys.ToArray();
                    break;
                case DataType.DOUBLE:
                    headers = tmpList[0].DoubleValues.Keys.ToArray();
                    break;
            }

            return headers;
        }
        
        public static UniversalObject CreateInstance(string[] data, string[] headers, DataSet dataSet)
        {
            var item = new UniversalObject(headers, data);
            if (dataSet != DataSet.NONE)
            {
                dataSets.TryGetValue(dataSet, out List<UniversalObject> tmpList);
                tmpList = tmpList is null ? new List<UniversalObject>() : tmpList;
                tmpList.Add(item);

                dataSets.Remove(dataSet);
                dataSets.Add(dataSet, tmpList);
            }
            return item;
        }
    }
}
