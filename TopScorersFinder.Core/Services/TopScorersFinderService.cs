using TopScorersFinder.Core.Interfaces;
using TopScorersFinder.Core.Models;

namespace TopScorersFinder.Core.Services
{
    public class TopScorersFinderService : ITopScorersFinder
    {
        public List<Person> FindTopScorers(IEnumerable<Person> persons)
        {
            var highestScore = persons.Max(p => p.Score);
            var topScorers = persons
                .Where(p => p.Score == highestScore)
                .OrderBy(p => p.SecondName)
                .ThenBy(p => p.FirstName)
                .ToList();
            return topScorers;
        }
    }
}
