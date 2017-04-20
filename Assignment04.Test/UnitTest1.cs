using NUnit.Framework;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Assignment04.Test
{
    [TestClass]
    public class UnitTest1
    {
        //This unit test checks that all the input side's of triangle are positive.
        [Test]
        public void checkPositive()
        {
            NUnit.Framework.Assert.IsTrue(TriangleSolver.isValidTriangle(5, 6, 7));
        }

        //This unit test checks thats the triangle gets formed using the sides.
        [Test]
        public void triangleFormed()
        {
            NUnit.Framework.Assert.IsTrue(TriangleSolver.isValidTriangle(5, 6, 7));
        }

        //This unit test checks that the triangle is not formed for specific input sides.
        [Test]
        public void triangleNotFormed()
        {
            NUnit.Framework.Assert.IsFalse(TriangleSolver.isValidTriangle(5, 6, 21));
        }

        //This unit test checks that one or more sides of triangle are zero value input.
        [Test]
        public void checkZeroValue()
        {
            NUnit.Framework.Assert.IsFalse(TriangleSolver.isValidTriangle(0,7,0));
        }

        //This unit test checks that one or more sides of triangle are negative value input.
        [Test]
        public void checkNegativeValue()
        {
            NUnit.Framework.Assert.AreEqual("not formed", TriangleSolver.Analyze(4,8,-3));
        }

        [Test]
        //This unit test checks that all the sides of triangle are equal i.e. triangle is Equilateral.
        public void checkEquilateral()
        {
            NUnit.Framework.Assert.AreEqual("Equilateral",TriangleSolver.Analyze(7,7,7));
        }

        //This unit test checks that none of the sides of triangle are equal i.e. triangle is Scalene.
        [Test]
        public void checkScalene()
        {
            NUnit.Framework.Assert.AreEqual("Scalene", TriangleSolver.Analyze(5, 6, 9));
        }

        //This unit test checks that any two sides of triangle are equal i.e. triangle is Isosceles
        [Test]
        public void checkIsosceles()
        {
            NUnit.Framework.Assert.AreEqual("Isosceles", TriangleSolver.Analyze(5, 6, 5));
        }
    }
}
