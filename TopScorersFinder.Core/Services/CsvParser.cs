using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopScorersFinder.Core.Interfaces;
using TopScorersFinder.Core.Models;

namespace TopScorersFinder.Core.Services
{
    public class CsvParser : ICsvParser
    {
        private readonly IFileReader _fileReader;

        public CsvParser(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public List<Person> ParseCsvFile(string filePath)
        {
            var lines = _fileReader.ReadAllLines(filePath).ToList();
            var persons = new List<Person>();

            for (int i = 1; i < lines.Count; i++) // Start at index 1 to skip the header row
            {
                var line = lines[i];
                var values = line.Split(',');
                string firstName = values[0].Trim();
                string secondName = values[1].Trim();
                int score = int.Parse(values[2].Trim());

                persons.Add(new Person(firstName, secondName, score));
            }

            return persons;
        }
    }
}
