using NUnit.Framework;
using NUnitDemonstration;
namespace TriangleTest
{
    public class TriangleTest
    {
        [TestFixture]
        public class  TriangleTest1
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";
                string actual=Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }



    }
}
