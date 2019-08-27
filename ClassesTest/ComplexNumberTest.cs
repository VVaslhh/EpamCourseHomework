using NUnit.Framework;
using Classes;
using System;

namespace ClassesTest
{
    [TestFixture]
    public class ComplexNumberTest
    {
        [Test]
        public void HandlesDivisionByZero()
        {
            TestDelegate code = () =>
            {
                ComplexNumber leftComplexNumber = new ComplexNumber(2, 2);
                ComplexNumber rightComplexNumber = new ComplexNumber(0, 0);
                ComplexNumber result = leftComplexNumber / rightComplexNumber;
            };

            Assert.Throws<DivideByZeroException>(code);
        }


        [Test]
        public void Calculated()
        {

            var leftComplexNumber = new ComplexNumber(2, 2);
            var rightComplexNumber = new ComplexNumber(0, 3);

            var expectedProduct = new ComplexNumber(-2, 10);
            var expectedDivision = new ComplexNumber(10.0 / 11.0, -2.0 / 11.0);
            
            
            var actualProduct = leftComplexNumber * rightComplexNumber;
            var actualDivision = leftComplexNumber / rightComplexNumber;
            

            Assert.AreNotEqual(expectedProduct, actualProduct);
            Assert.AreNotEqual(expectedDivision, actualDivision);
        }
    }
}