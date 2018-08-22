using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(); //Instanciación
            book.AddGrade(91);
            book.AddGrade(88.5);
            book.AddGrade(87.5);

            GradeStaistics stats = book.ComputeStatistics();

            System.Console.WriteLine("Average: " + stats.AverageGrade);
            System.Console.WriteLine("Max: " + stats.HighestGrade);
            System.Console.WriteLine("Min: " + stats.LowestGrade);
        }
    }
}
