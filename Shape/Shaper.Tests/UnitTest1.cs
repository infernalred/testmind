using System;
using NUnit.Framework;

namespace Shaper.Tests
{
    public class Tests
    {
        [Test]
        public void Circle_ItShould_be_78_54()
        {
            var circle = new Circle(5);

            const double expected = 78.54;

            var actual = circle.Square();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Circle_ItShould_be_1661_90()
        {
            var circle = new Circle(23);

            const double expected = 1661.90;

            var actual = circle.Square();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Triangle_ItShould_be_Error_A()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(0, 4, 3);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_Error_B()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(2, 0, 3);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_Error_C()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(1, 4, 0);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_Error_Bigger_A()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(5, 2, 1);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_Error_Bigger_B()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(1, 4, 2);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_Error_Bigger_C()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(1, 4, 10);
            });

        }
        
        [Test]
        public void Triangle_ItShould_be_57_24()
        {
            var triangle = new Triangle(23, 5, 24);

            const double expected = 57.24;

            var actual = triangle.Square();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Triangle_ItShould_be_7_48()
        {
            var triangle = new Triangle(3, 5, 6);

            const double expected = 7.48;

            var actual = triangle.Square();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Triangle_ItShould_be_Right1()
        {
            var triangle = new Triangle(4.0, 5.0, 3.0);

            const bool expected = true;

            var actual = triangle.IsRightTriangle();
            
            Assert.AreEqual(expected, actual);
        }
    }
}

