using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAssignment2
{
    public static class TriangleSolver
    {
        public static string triangleType;
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            string analyzeOutput = "";
            triangleType = "";
            string isTriangle = "";
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                isTriangle = "These digits do form a triangle. ";
                if (sideA != sideB && sideA != sideC && sideB != sideC)
                {
                    triangleType = "Type of: Scalene\n";
                }
                else if (sideA == sideB && sideB == sideC)
                {
                    triangleType = "Type of: Equilateral\n";
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    triangleType = "Type of: Isosceles.\n";
                }
            }
            else
            {
                isTriangle = "These digits do not form a triangle\n";
            }

            analyzeOutput = isTriangle + triangleType;

            return analyzeOutput;
        }
    }
}
