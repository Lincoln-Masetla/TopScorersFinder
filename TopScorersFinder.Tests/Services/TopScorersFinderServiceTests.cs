using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopScorersFinder.Core.Models;
using TopScorersFinder.Core.Services;

namespace TopScorersFinder.Tests.Services
{
    public class TopScorersFinderServiceTests
    {
        [Test]
        public void FindTopScorers_ShouldReturnExpectedTopScorers()
        {
            var persons = new List<Person>
            {
                new Person("John", "Doe", 50),
                new Person("Jane", "Doe", 60),
                new Person("Joe", "Smith", 60),
                new Person("Emily", "Adams", 40)
            };

            var topScorersFinderService = new TopScorersFinderService();
            var topScorers = topScorersFinderService.FindTopScorers(persons);

            Assert.That(topScorers.Count, Is.EqualTo(2));
            Assert.That(topScorers[0].ToString(), Is.EqualTo("Jane Doe"));
            Assert.That(topScorers[0].Score, Is.EqualTo(60));
            Assert.That(topScorers[1].ToString(), Is.EqualTo("Joe Smith"));
            Assert.That(topScorers[1].Score, Is.EqualTo(60));
        }
    }
}