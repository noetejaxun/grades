using System;
using System.Collections.Generic; // Class to List object
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
    class GradeBook {
        private List<double> grades; // = new List<double>(); // List object
        public static double MinimumGrade = 0;
        public static double MaximumGrade = 100;
        public GradeBook() { // Constructor
            grades = new List<double>();
        }
        public void AddGrade(double grade) { // Method
            grades.Add(grade);
        }
        
        public GradeStaistics ComputeStatistics(){
            GradeStaistics stats = new GradeStaistics();

            double sum = 0;
            foreach (double grade in grades) {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}