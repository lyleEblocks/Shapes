using System;
using Xunit;

namespace Shape.Tests
{
    /// <summary>
    ///     This test class will test the Rectangle class methods.
    /// </summary>
    public class RectangleTests
    {
        [Fact]
        /// <summary>
        ///     Tests that two rectangles are equal.
        /// </summary>
        public void Should_Ensure_The_Two_Rectangles_Are_Equal()
        {
            //  Arrange
            Rectangle rectangleA = new Rectangle(10, 20);
            Rectangle rectangleB = new Rectangle(10,20);

            //  Act
            bool result = rectangleA.Equals(rectangleB);

            //  Assert
            Assert.True(result);
        }

        [Fact]
        /// <summary>
        ///     Tests that two rectangles are not equal.
        /// </summary>
        public void Should_Ensure_The_Two_Rectangles_Are_NotEqual()
        {
            //  Arrange
            Rectangle rectangleA = new Rectangle(11, 20);
            Rectangle rectangleB = new Rectangle(10,20);

            //  Act
            bool result = rectangleA.Equals(rectangleB);

            //  Assert
            Assert.False(result);
          
        }

        [Fact]
        /// <summary>
        ///     Tests that a <see cref="OverflowExeption"> exception is thrown when the constructor parameter are less than or equal to 0.
        /// </summary>
        public void Should_Ensure_Rectangle_Has_Valid_Parameters()
        {
            //  Arrange
            //  Act
            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Rectangle rectangleA = new Rectangle(-11, 20);
            });          
        }

        [Fact]
        /// <summary>
        ///     Tests that the area of the rectangle is calculated successfully.  
        /// </summary>
        public void Calculate_Area_Of_Rectangle_Successfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculateArea();

            // Assert
            Assert.Equal(110, result);
        }

        [Fact]
        /// <summary>
        ///     Tests that a <see cref="OverflowExeption"> exception is thrown when the length and width of the rectangle is too large to calculate area.
        /// </summary>
        public void Calculate_Area_Of_Rectangle_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<OverflowException>(() =>
            {
               Rectangle rectangle = new Rectangle(double.MaxValue, double.MaxValue);
               rectangle.CalculateArea();
            });
            
        }

        [Fact]
        /// <summary>
        ///     Tests that the perimeter of the rectangle is calculated successfully.  
        /// </summary>
        public void Calculate_Perimeter_Of_Rectangle_Successfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculatePerimeter();

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        /// <summary>
        ///     Tests that a <see cref="OverflowExeption"> exception is thrown when the length and width of the rectangle is too large to calculate perimeter.
        /// </summary>
        public void Calculate_Perimeter_Of_Rectangle_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<OverflowException>(() =>
            {
               Rectangle rectangle = new Rectangle(double.MaxValue, double.MaxValue);
               rectangle.CalculatePerimeter();
            });
            
        }

    }
}
