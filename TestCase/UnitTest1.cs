using NUnit.Framework;
using NUnitdemonstration;  // Adjust namespace if needed

namespace TestCase
{
    public class Tests
    {
        [TestFixture]  // Indicates that this class contains NUnit tests
        public class TriangleTests
        {
            // Test Case: Valid triangle where angles sum up to 180
            [Test]
            public void Test_ValidTriangle_Angles_60_60_60()
            {
                var result = Triangle.ValidTriangle(60, 60, 60);  // 60 + 60 + 60 = 180
                Assert.AreEqual("The triangle is valid.", result);
            }

            // Test Case: Another valid triangle where angles sum up to 180
            [Test]
            public void Test_ValidTriangle_Angles_90_45_45()
            {
                var result = Triangle.ValidTriangle(90, 45, 45);  // 90 + 45 + 45 = 180
                Assert.AreEqual("The triangle is valid.", result);
            }

            // Test Case: Invalid triangle, sum of angles is more than 180
            [Test]
            public void Test_InvalidTriangle_SumMoreThan180()
            {
                var result = Triangle.ValidTriangle(90, 60, 40);  // 90 + 60 + 40 = 190
                Assert.AreEqual("The triangle is NOT valid.", result);
            }

            // Test Case: Invalid triangle, sum of angles is less than 180
            [Test]
            public void Test_InvalidTriangle_SumLessThan180()
            {
                var result = Triangle.ValidTriangle(50, 60, 50);  // 50 + 60 + 50 = 160
                Assert.AreEqual("The triangle is NOT valid.", result);
            }

            // Test Case: Invalid triangle, all angles are zero
            [Test]
            public void Test_InvalidTriangle_AllAnglesZero()
            {
                var result = Triangle.ValidTriangle(0, 0, 0);  // 0 + 0 + 0 = 0
                Assert.AreEqual("The triangle is NOT valid.", result);
            }

            // Test Case: Invalid triangle, one angle is negative
            [Test]
            public void Test_InvalidTriangle_NegativeAngle()
            {
                var result = Triangle.ValidTriangle(-30, 90, 120);  // Negative angle, invalid
                Assert.AreEqual("The triangle is NOT valid.", result);
            }
        }
    }
}