using System;
using System.Collections.Generic;
using System.Text;

namespace Exporter.Models.Common
{
    public interface IParserCSV : IParserBase
    {
        string ParseWord();
        string ParseWord(char delimiter);
    }
}
