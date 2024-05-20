using TopScorersFinder.Core.Interfaces;

namespace TopScorersFinder.Core.Services
{
    public class FileReader : IFileReader
    {
        public IEnumerable<string> ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
