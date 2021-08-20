using System;
using Xunit;
using RectangleShape;

namespace RectangleTests
{
  
    public class RectangleTest
    {
        [Fact]
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
        public void Calculate_Area_Of_Rectangle_Successfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculateArea();

            // Assert
            Assert.True(result == 110);
        }

        [Fact]
        public void Calculate_Area_Of_Rectangle_Exception()
        {
            // Arrange

            // Act
            
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
               Rectangle rectangle = new Rectangle(-11, 10); 
            });
            
        }
    }
}
