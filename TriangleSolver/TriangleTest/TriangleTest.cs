/* Alfredo Lozano
 * Prog2070 - Assignment 2
 * Unit test for Triangle Solver
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        //one (1) test for a valid equilateral triangle EQUILATERAL
        [Test]
        public void TriangleSolver_Equilateral_Valid()
        {

            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 2;

            string outputMessage = "";

            outputMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            string expectedOutput = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            Assert.AreEqual(expectedOutput, outputMessage);
        }
    }
}
