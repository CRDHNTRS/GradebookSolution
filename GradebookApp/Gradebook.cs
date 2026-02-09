using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookApp
{
    public class Gradebook
    {
        private readonly List<double> _grades = new();

        // Add single grade
        public void AddGrade(double grade)
        {
            if (grade < 0 || grade > 100)
                throw new ArgumentOutOfRangeException(nameof(grade), "Grade must be between 0 and 100.");
            _grades.Add(grade);
        }

        // Add multiple grades (overload)
        public void AddGrade(IEnumerable<double> grades)
        {
            foreach (var grade in grades)
            {
                AddGrade(grade);
            }
        }

        public double GetAverage()
        {
            return _grades.Count == 0 ? 0 : _grades.Average();
        }

        public double GetHighest()
        {
            return _grades.Count == 0 ? 0 : _grades.Max();
        }

        public double GetLowest()
        {
            return _grades.Count == 0 ? 0 : _grades.Min();
        }

        public int GetCount()
        {
            return _grades.Count;
        }

        public void Clear()
        {
            _grades.Clear();
        }
    }
}
