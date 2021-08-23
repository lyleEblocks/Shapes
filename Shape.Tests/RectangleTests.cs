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
        public void Calculate_Area_Of_Rectangle_Unsuccessfully()
        {
            // Arrange
            Rectangle rect = new Rectangle(10,11);

            // Act
            double result = rect.CalculateArea();

            // Assert
            Assert.NotEqual(100, 110);
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
          [Fact]
        public void Calculate_Circumfrance_of_A_Circle_Successfully()
        {
            // Arrange
            Circle circumf = new Circle(3.141, 5);
            // Act
            double result = circumf.CalculateCircum(3.141, 5);
            // Assert
           Assert.Equal(31.41592653589793, result);
            
        }
         [Fact]
        public void Calculate_Circumfrance_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle circumf = new Circle(3.141, -5);});
        }
        [Fact]
        public void Calculate_Area_of_A_Circle_Successfully()
        {
            // Arrange
            Circle area = new Circle(3.141 ,5);
            // Act
            double result = area.Calculate_Area_Of_Circle(3.141, 5);
            // Assert
            Assert.Equal(78.53981633974483, result);    
        }
         [Fact]
        public void Calculate_Area_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle area = new Circle(3.141, -5);});
        }
         [Fact]
        public void Calculate_Diameter_of_A_Circle_Successfully()
        {
            // Arrange
            Circle diameter = new Circle(5, 2);
            // Act
            double result = diameter.Calculate_Diameter_Of_Circle(5, 2);
            // Assert
            Assert.Equal( 10 ,result);
        }
          [Fact]
        public void Calculate_Diameter_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle diameter = new Circle(2, -5);});
        }
        [Fact]
        public void Calculate_Area_of_A_Square_Successfully()
        {
            // Arrange
             Square area = new Square(4);
            // Arrange
            double result = area.Calculate_Area_of_A_Square(4);
            // Assert
            Assert.Equal(16, result);
        }
        [Fact]
        public void Calculate_Area_of_A_Square_Usuccessfully()
        {
            // Arrange
             Square area1 = new Square(0);
            // Arrange
            double result = area1.Calculate_Area_of_A_Square(0);
            // Assert
            Assert.NotEqual(16, result);
        }
      [Fact]
        public void Calculate_Perimeter_of_A_Square_Successfully()
        {
            // Arrange
             Square perimeter = new Square(8);
            // Arrange
            double result = perimeter.Calculate_Perimeter_of_A_Square(8);
            // Assert
            Assert.Equal(32, result);
        }
        [Fact]
        public void Calculate_Perimeter_of_A_Square_Usuccessfully()
        {
            // Arrange
             Square perimeter = new Square(0);
            // Arrange
            double result = perimeter.Calculate_Perimeter_of_A_Square(0);
            // Assert
            Assert.NotEqual(32, result);
        }
        [Fact]
        public void Calculate_Diagonal_of_A_Square_Successfully()
        {
            // Arrange
             Square diagonal = new Square(6);
            // Arrange
            double result = diagonal.Calculate_Diagonal_of_A_Square(6);
            // Assert
            Assert.Equal(72, result);
        }
        [Fact]
        public void Calculate_Diagonal_of_A_Square_Usuccessfully()
        {
            // Arrange
             Square diagonal = new Square(0);
            // Arrange
            double result = diagonal.Calculate_Diagonal_of_A_Square(0);
            // Assert
            Assert.NotEqual(72, result);
        }
        
       
    }
}