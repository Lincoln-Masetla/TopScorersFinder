using TopScorersFinder.Core.Models;

namespace TopScorersFinder.Core.Interfaces
{
    public interface ICsvParser
    {
        List<Person> ParseCsvFile(string filePath);
    }
}
