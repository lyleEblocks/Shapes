using System;
using Xunit;

namespace Shape.Tests
{
    public class RectangleTests
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
            Assert.Equal(110, result);
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
        /// <summary>
        ///      Testing positve <see cref= "Circle"/> calculations in <see cref= "Should_Calculate_Circumference_Of_Circle_Successfully"/>
        /// </summary>
        [Fact]
        public void Should_Calculate_Circumference_Of_Circle_Successfully()
        {
            //Arrange
            Circle circumf = new Circle(3.141, 5);
            //Act
            double result = circumf.CalculateCircum(3.141, 5);
            //Assert
            Assert.Equal(31.41592653589793,result);
        }
        /// <summary>
        ///     Testing positive calculation of diameter works in <see cref="Should_Calculate_Diameter_Of_Circle_Successfully"/>
        /// </summary>
        [Fact]
        public void Should_Calculate_Diameter_Of_Circle_Successfully()
        {
            //Arrange
            Diameter diameter = new Diameter(5);
            //Act
            double result = diameter.CalculateDiameter(5);
            //Assert
            Assert.Equal(10, result);
        }

       
    }}

        
    

