using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ComplexNumber
    {
        #region Fields
        public readonly double realPart, imaginaryPart;
        #endregion

        #region Constructor
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }
        #endregion

        #region Operators overloading
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber(
                realPart: (c1.realPart * c2.realPart) - (c1.imaginaryPart * c2.imaginaryPart),
                imaginaryPart: (c1.realPart * c2.imaginaryPart) + (c1.imaginaryPart * c2.realPart));

            return complex;
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            if (c2.realPart == 0 && c2.imaginaryPart == 0)
            {
                throw new DivideByZeroException();
            }
            ComplexNumber complex = new ComplexNumber(
                realPart: ((c1.realPart * c2.realPart) + (c1.imaginaryPart * c2.realPart)) / ((c2.realPart * c2.realPart) + (c2.imaginaryPart * c2.imaginaryPart)),
                imaginaryPart: ((c2.realPart * c1.imaginaryPart) - (c1.realPart * c2.imaginaryPart)) / ((c2.realPart * c2.realPart) + (c2.imaginaryPart * c2.imaginaryPart)));
            return complex;
        }
        #endregion
    }
}
