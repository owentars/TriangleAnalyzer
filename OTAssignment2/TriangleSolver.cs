using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            string analyzeOutput = "";
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                if (sideA != sideB && sideA != sideC && sideB != sideC)
                {
                    analyzeOutput = "This is a Scalene Triangle.\n";
                }
                else if (sideA == sideB && sideB == sideC)
                {
                    analyzeOutput = "This is an Equilateral triangle.\n";
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    analyzeOutput = "This is an Isosceles triangle.\n";
                }
            }
            else
            {
                analyzeOutput = "These digits do not form a triangle\n";
            }

            return analyzeOutput;
        }
    }
}
