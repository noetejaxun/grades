using System;
using System.Collections.Generic; // Class to List object
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStaistics {
        public GradeStaistics() {
            HighestGrade = 0;
            LowestGrade = double.MaxValue;
        }
        public double AverageGrade;
        public double HighestGrade;
        public double LowestGrade;
    }
}