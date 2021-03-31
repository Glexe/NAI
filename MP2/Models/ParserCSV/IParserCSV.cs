
namespace Exporter.Models.Common
{
    public interface IParserCSV
    {
        string[] ParseHeaders();
        string[] ParseLine();
        string[] ParseLine(int index);
        void Dispose();
    }
}
