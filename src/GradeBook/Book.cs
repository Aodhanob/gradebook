using System.Diagnostics.Contracts;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace GradeBook
{

    class Book
    {
        public List<double> grades;
        private string name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"Highest grade: {highGrade}");
            Console.WriteLine($"Lowest grade: {lowGrade:N2}");
            Console.WriteLine($"Average grade: {result:N2}");
        }

    }

}