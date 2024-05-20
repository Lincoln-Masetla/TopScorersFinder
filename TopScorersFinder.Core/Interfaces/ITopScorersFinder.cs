using TopScorersFinder.Core.Models;

namespace TopScorersFinder.Core.Interfaces
{
    public interface ITopScorersFinder
    {
        List<Person> FindTopScorers(IEnumerable<Person> persons);
    }
}
