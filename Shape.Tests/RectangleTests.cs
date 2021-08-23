using System;
using Xunit;
using RectangleShape;

namespace RectangleTests
{
     /// <summary>
    ///     This Class provide tests for both the negative, positive and exception cases for the methods in the Rectangle.cs class
    /// </summary>
  
    public class RectangleTest
    {
        /// <summary>
        ///     This method checks if two rectangles with equal properties are equal
        /// </summary>
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

        /// <summary>
        ///     This method checks if two rectangles with different properties are not equal
        /// </summary>
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

        /// <summary>
        ///      This method checks if the length and the width are not negative
        /// </summary>
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

        /// <summary>
        ///     This method checks the positive scenario for the calculation of the Area of a rectangle
        /// </summary>
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
        
        /// <summary>
        ///     This method checks the negative scenario for the CalculateArea method
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Rectangle_Unsuccessfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculateArea();

            // Assert
            Assert.True(result != 210);
        }

        /// <summary>
        ///     This Method Checks the Exception Scenario of the CalculateArea method
        /// </summary>
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
        /// <summary>
        ///     This Method checks the positive scenario of the CalculatePerimeter method
        /// </summary>
        [Fact]
        public void Calculate_Perimeter_Of_Rectangle_Successfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculatePerimeter();

            // Assert
            Assert.True(result == 42);
        }

        /// <summary>
        ///     This method checks the negative scenario of the CalculatePerimeter method
        /// </summary>
        [Fact]
        public void Calculate_Perimeter_Of_Rectangle_Unsuccessfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculatePerimeter();

            // Assert
            Assert.True(result != 52);
        }

        /// <summary>
        ///     This method checks the exception scenario for the perimeter of a rectangle method.
        /// </summary>
         [Fact]
        public void Calculate_Perimeter_Of_Rectangle_Exception()
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
