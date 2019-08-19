using NUnit.Framework;
using Classes;

namespace ClassesTest
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void Perimeter_SidesOfRectangle_Calculated()
        {
            var sut = new Rectangle(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0));

            Assert.That(sut.Perimeter(), Is.EqualTo(20));
        }


        [Test]
        public void Area_SidesOfRectangle_Calculated()
        {
            var sut = new Rectangle(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0));

            Assert.That(sut.Area(), Is.EqualTo(21));
        }

        [Test]
        public void PerimeterProperty_SidesOfRectangle_Calculated()
        {
            var sut = new RectangleAutoImplementedProperties(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0));

            Assert.That(sut.PerimeterProperty, Is.EqualTo(20));
        }


        [Test]
        public void AreaProperty_SidesOfRectangle_Calculated()
        {
            var sut = new RectangleAutoImplementedProperties(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0));

            Assert.That(sut.AreaProperty, Is.EqualTo(21));
        }

        [Test]
        public void PerimeterStatic_SidesOfRectangle_Calculated()
        {
            Assert.That(StaticRectangle.PerimeterStatic(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0)), Is.EqualTo(20));
        }


        [Test]
        public void AreaStatic_SidesOfRectangle_Calculated()
        {
            Assert.That(StaticRectangle.AreaStatic(new CoordsOfPoint(0, 3), new CoordsOfPoint(7, 0)), Is.EqualTo(21));
        }
    }
}
