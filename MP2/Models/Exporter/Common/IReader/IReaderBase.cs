using System;
using System.Collections.Generic;
using System.Text;

namespace Exporter.Models.Common.IReader
{
    public interface IReaderBase
    {
        T ReadLine<T>();
        T ReadLine<T>(int index);

        void Dispose();
    }
}
