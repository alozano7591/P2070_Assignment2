﻿/* Alfredo Lozano
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

            string actualMessage = "";

            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            string expectedOutput = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 1 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_IsoscelesSide1and2_Valid()
        {

            Triangle triangle = new Triangle();

            int firstSide = 3;
            int secondSide = 3;
            int thirdSide = 5;

            string actualMessage = "";

            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            string expectedOutput = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for first invalid triangle check. Checks if having sum of sides 1 and 2 
        /// less than side 3 triggers proper output error.
        /// </summary>
        [Test]
        public void TriangleSolver_TriangleSidesLessThanThird_Invalid()
        {

            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 4;

            string actualMessage = "";

            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            string expectedOutput = "Based on the values entered, the triangle is INVALID";

            Assert.AreEqual(expectedOutput, actualMessage);
        }

    }
}
