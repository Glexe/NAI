using System.Threading.Tasks;

namespace Exporter.Models
{
    public interface IParserBase
    {
        string[] ParseLine();
        string[] ParseLine(int index);
        Task<string[]> ParseLineAsync();
        string[] ParseToEnd();
        string[][] ParseToEnd2D();
        Task<string[][]> ParseToEnd2DAsync();


        void Dispose();
    }
}
