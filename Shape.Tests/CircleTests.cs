using System;
using Xunit;

namespace Shape 
{
    /// <summary>
    /// This class will test our Circle class
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        ///     This method will test if two circles are equal.
        /// </summary>
        [Fact]
        public void Should_Ensure_Two_Circles_Are_Equal()
        {
            //Arrange
            Circle circleA = new Circle(20);
            Circle circleB = new Circle(20);
            
            //Act
            bool result = circleA.Equals(circleB);

            //Assert
            Assert.True(result);            
        }

        /// <summary>
        ///     This method will test that two circles are not equal.
        /// </summary>
        [Fact]
        public void Should_Ensure_Two_Circles_Are_Not_Equal()
        {
            //Arrange
            Circle circleA = new Circle(20);
            Circle circleB = new Circle(30);
            
            //Act
            bool result = circleA.Equals(circleB);

            //Assert
            Assert.False(result);            
        }

        /// <summary>
        ///     This metrhod will test that a circle can't be created with a negative radius.
        /// </summary>
        [Fact]
        public void Should_Ensure_Circle_Has_Valid_Parameters()
        {
            //Arrange
                        
            //Act
            
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Circle circleA = new Circle(-20);
            });
        }
        
        /// <summary>
        ///     This method will test the calculation the area of a circle based on its radius.
        /// </summary>     
        [Fact]
        public void Should_Calculate_Area_Of_Circle()
        {
            //Arrange
            Circle circleA = new Circle(10);
            double expected = 314.15926535897932; 
                        
            //Act
            double area = circleA.CalculateArea();
            
            //Assert
            Assert.Equal(area, expected);
        } 

        /// <summary>
        ///     This method will test the calculation of the circumference of a circle based on its radius.
        /// </summary>
        [Fact]
        public void Should_Calculate_Circumference_Of_Circle()
        {
            //Arrange
            Circle circleB = new Circle(10);
            double expected = 62.83185307179586;

            //Act
            double result = circleB.CalculateCircumference();

            //Assert
            Assert.Equal(result, expected);       
        }

        /// <summary>
        ///     This method will test the calculation of the diameter of a circle based on its radius.
        /// </summary>
        [Fact]
        public void Should_Calculate_Diameter_Of_Circle()
        {
            //Arrange
            Circle circleC = new Circle(10);
            int expected = 20;

            //Act
            int result = circleC.CalculateDiameter();

            //Assert
            Assert.Equal(result, expected);
        }
    }
}