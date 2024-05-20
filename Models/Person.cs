namespace TopScorersFinder.Core.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Score { get; set; }

        public Person(string firstName, string secondName, int score)
        {
            FirstName = firstName;
            SecondName = secondName;
            Score = score;
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}";
        }
    }
}
