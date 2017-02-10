using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAssignment2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// Analyzes data to see if given data is a triangle, if so what kind of triangle it is.
        /// </summary>
        /// <param name="sideA">parsed user input for side A</param>
        /// <param name="sideB">parsed user input for side B</param>
        /// <param name="sideC">parsed user input for side C</param>
        /// <returns></returns>
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            string analyzeOutput = "";

            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                analyzeOutput += "These digits do form a triangle. ";
                if (sideA != sideB && sideA != sideC && sideB != sideC)
                {
                    analyzeOutput += "Type of: Scalene\n";
                }
                else if (sideA == sideB && sideB == sideC)
                {
                    analyzeOutput += "Type of: Equilateral\n";
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    analyzeOutput += "Type of: Isosceles.\n";
                }
            }
            else
            {
                analyzeOutput += "These digits do not form a triangle\n";
            }

            return analyzeOutput;
        }
    }
}
