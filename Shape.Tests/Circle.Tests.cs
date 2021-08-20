using System;
using Xunit;
using ShapeCircle;

namespace CircleTests
{
    public class CircleTest
    {   
        [Fact]
        public void Sould_Ensure_two_Circles_Are_Equal()
        {
            //Arrange
            Circle CircleA = new Circle(10);
            Circle CircleB = new Circle(10);

            //Act
            bool result = CircleA.Equals(CircleB);

            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Sould_Ensure_two_Circles_Are_Not_Equal()
        {
            //Arrange
            Circle CircleA = new Circle(11);
            Circle CircleB = new Circle(10);

            //Act
            bool result = CircleA.Equals(CircleB);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Ensure_Circle_Has_Valid_Radius()
        {
            //  Arrange

            //  Act

            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Circle circleA = new Circle(-11);
            });          
        }

        [Fact]
        public void Calculate_The_Area_Of_A_Circle_Successfully()
        {
            //Arrange
            Circle circleA = new Circle(10);
            const double trueArea = 100*3.14;

            //Act
            double testedArea = circleA.CalculateTheAreaOfACircle();

            //Assert
            Assert.True(trueArea == testedArea);
        }

        [Fact]
        public void Calculate_The_Area_Of_A_Circle_Unsuccessfully()
        {
            //Arrange
            Circle circleA = new Circle(10);
            const double trueArea = 2*100*3.14;

            //Act
            double testedArea = circleA.CalculateTheAreaOfACircle();

            //Assert
            Assert.False(trueArea == testedArea);
        }

        [Fact]
        public void Calculate_The_Area_Of_A_CircleA_Is_Equal_To_Area_Of_CircleB_Successfully()
        {
            //Arrange
            Circle circleA = new Circle(10);
            Circle circleB = new Circle(10);

            //Act
            double testedAreaA = circleA.CalculateTheAreaOfACircle();
            double testedAreaB = circleB.CalculateTheAreaOfACircle();
            bool result = testedAreaA.Equals(testedAreaB);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Calculate_The_Area_Of_A_CircleA_Is_Not_Equal_To_Area_Of_CircleB_Successfully()
        {
            //Arrange
            Circle circleA = new Circle(10);
            Circle circleB = new Circle(101);

            //Act
            double testedAreaA = circleA.CalculateTheAreaOfACircle();
            double testedAreaB = circleB.CalculateTheAreaOfACircle();
            bool result = testedAreaA.Equals(testedAreaB);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Ensure_Circle_Has_Non_Valid_Radius_For_Area()
        {
            //  Arrange

            //  Act

            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Circle circleA = new Circle(-11);
            });          
        }

        [Fact]
        public void Calculate_The_Perimeter_Of_A_Circle_Successfully()
        {
            //Arrange
            Circle circleA = new Circle(10);
            const double truePerimeter = 2*10*3.14;

            //Act
            double calculatedPerimeter = circleA.CalculateThePerimeterOfACircle();

            //Assert
            Assert.True(truePerimeter == calculatedPerimeter);
        }

        [Fact]
        public void Calculate_The_Perimeter_Of_A_Circle_Unsuccessfully()
        {
            //Arrange
            Circle circleA = new Circle(11);
            const double truePerimeter = 2*10*3.14;

            //Act
            double calculatedPerimeter = circleA.CalculateThePerimeterOfACircle();

            //Assert
            Assert.False(truePerimeter == calculatedPerimeter);
        }

        [Fact]
        public void Should_Ensure_Circle_Has_Non_Valid_Radius_For_Perimeter()
        {
            //  Arrange

            //  Act

            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Circle circleA = new Circle(-11);
            }); 
          
        }

    }
}