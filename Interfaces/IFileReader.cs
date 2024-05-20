namespace TopScorersFinder.Core.Interfaces
{
    public interface IFileReader
    {
        IEnumerable<string> ReadAllLines(string filePath);
    }
}
