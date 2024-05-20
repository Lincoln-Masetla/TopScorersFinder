using TopScorersFinder.Core.Models;

namespace TopScorersFinder.Tests.Models
{
    public class PersonTests
    {
        [Test]
        public void ToString_ShouldReturnFullName()
        {
            var person = new Person("John", "Doe", 50);
            Assert.That(person.ToString(), Is.EqualTo("John Doe"));
        }
    }
}
