using NUnit.Framework;
using Classes;

namespace ClassesTest
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void CircumferenceOfCircle_FindingCircumferenceUsingRadius_Calculated()
        {
            var sut = new Circle();

            Assert.That(sut.CircumferenceOfCircle(2), Is.EqualTo(12.56636));
        }


        [Test]
        public void AreaOfCircle_FindingAreaUsingRadius_Calculated()
        {
            var sut = new Circle();

            Assert.That(sut.AreaOfCircle(2), Is.EqualTo(12.56636));
        }

        [Test]
        public void CircumferenceOfCircle_StaticFindingCircumferenceUsingRadius_Calculated()
        {
            Assert.That(StaticCircle.CircumferenceOfCircle(2), Is.EqualTo(12.56636));
        }


        [Test]
        public void AreaOfCircle_StaticFindingAreaUsingRadius_Calculated()
        {
            Assert.That(StaticCircle.AreaOfCircle(2), Is.EqualTo(12.56636));
        }
    }
}
