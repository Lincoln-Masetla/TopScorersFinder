using TopScorersFinder.Core.Services;
using TopScorersFinder.Core.Interfaces;

namespace TopScorersFinder.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "TestData.csv";
            IFileReader fileReader = new FileReader();
            ICsvParser csvParser = new CsvParser(fileReader);
            ITopScorersFinder topScorersFinder = new TopScorersFinderService();

            var persons = csvParser.ParseCsvFile(filePath);
            var topScorers = topScorersFinder.FindTopScorers(persons);

            Console.WriteLine("Top scorers:");
            foreach (var scorer in topScorers)
            {
                Console.WriteLine(scorer);
            }
            Console.WriteLine("Score: " + topScorers[0].Score);
        }
    }
}