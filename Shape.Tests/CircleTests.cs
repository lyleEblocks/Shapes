using System;
using Xunit;

namespace Shape 
{
    public class CircleTests
    {
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