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
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 2;
            string expectedOutput = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 1 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_IsoscelesSideOneAndTwo_Valid()
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
        /// Tests for Isosceles. Checks if properly validates that sides 1 and 3 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_IsoscelesSideOneAndThree_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 3;
            int secondSide = 5;
            int thirdSide = 3;
            string expectedOutput = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 3 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_IsoscelesSideTwoAndThree_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 3;
            string expectedOutput = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Five (5) tests for a valid scalene triangle
        /// <summary>
        /// Tests for Scalene. 1st.
        /// </summary>
        [Test]
        public void TriangleSolver_ScaleneOne_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 6;
            string expectedOutput = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Five (5) tests for a valid scalene triangle
        /// <summary>
        /// Tests for Scalene. 2nd
        /// </summary>
        [Test]
        public void TriangleSolver_ScaleneTwo_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 3;
            string expectedOutput = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Five (5) tests for a valid scalene triangle
        /// <summary>
        /// Tests for Scalene. 3rd
        /// </summary>
        [Test]
        public void TriangleSolver_ScaleneThree_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 6;
            int secondSide = 3;
            int thirdSide = 5;
            string expectedOutput = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Five (5) tests for a valid scalene triangle
        /// <summary>
        /// Tests for Scalene. 4th
        /// </summary>
        [Test]
        public void TriangleSolver_ScaleneFour_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 3;
            string expectedOutput = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Five (5) tests for a valid scalene triangle
        /// <summary>
        /// Tests for Scalene. 5th
        /// </summary>
        [Test]
        public void TriangleSolver_ScaleneFive_Valid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 3;
            int secondSide = 6;
            int thirdSide = 5;
            string expectedOutput = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Three (3) tests for verifying a zero length for one or more sides
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 3 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_ZeroLengthSideOne_InValid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 0;
            int secondSide = 6;
            int thirdSide = 5;
            string expectedOutput = "At least one side of your triangle has a zero length and is thus invalid";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Three (3) tests for verifying a zero length for one or more sides
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 3 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_ZeroLengthSideTwo_InValid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 6;
            int secondSide = 0;
            int thirdSide = 5;
            string expectedOutput = "At least one side of your triangle has a zero length and is thus invalid";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        //  Three (3) tests for verifying a zero length for one or more sides
        /// <summary>
        /// Tests for Isosceles. Checks if properly validates that sides 3 and 2 are the same length, but not side 3.
        /// </summary>
        [Test]
        public void TriangleSolver_ZeroLengthSideThree_InValid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 0;
            string expectedOutput = "At least one side of your triangle has a zero length and is thus invalid";
            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
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
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 4;
            string actualMessage = "";
            string expectedOutput = "Based on the values entered, the triangle is INVALID";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for first invalid triangle check. Checks if having sum of sides 1 and 3 
        /// less than side 2 triggers proper output error.
        /// </summary>
        [Test]
        public void TriangleSolver_TriangleSidesLessThanSecond_Invalid()
        {
            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 3;
            int secondSide = 8;
            int thirdSide = 4;
            string expectedOutput = "Based on the values entered, the triangle is INVALID";

            //act
            string actualMessage = "";
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

        // Three (3) tests for a valid isosceles triangle
        /// <summary>
        /// Tests for first invalid triangle check. Checks if having sum of sides 3 and 2 
        /// less than side 1 triggers proper output error.
        /// </summary>
        [Test]
        public void TriangleSolver_TriangleSidesLessThanFirst_Invalid()
        {

            //arrange
            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 7;
            int thirdSide = 4;
            string expectedOutput = "Based on the values entered, the triangle is INVALID";

            string actualMessage = "";

            //act
            actualMessage = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expectedOutput, actualMessage);
        }

    }
}
