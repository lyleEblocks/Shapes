using System;
using Xunit;
using ShapeCircle;

namespace CircleTests
{
    /// <summary>
    ///     This Class provide tests for both the negative, positive and exception cases for the methods in the circle.cs class
    /// </summary>
    public class CircleTest
    {    
        
        /// <summary>
        ///     This method checks if two circles with equal radii are equal
        /// </summary>
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
        /// <summary>
        ///     This method checks if two circles with different radii are not equal
        /// </summary>

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
        /// <summary>
        ///     This method checks if the Radius is not negative
        /// </summary>
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
        /// <summary>
        ///     This method confirms if the CalculateTheAreaOfACirCle method works correclly 
        /// </summary>
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
        /// <summary>
        ///     This method tests the negative scenario of the CalculateTheAreaOfACirCle method
        /// </summary>

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
        /// <summary>
        ///     This method tests the equality of the area of two circles with equal Radii
        /// </summary>

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
        /// <summary>
        ///      This method confirms that two circles of different radii have non equal area
        /// </summary>

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
        /// <summary>
        ///     This method tests for negative radius which throws an exception if a circle has a negative radus
        /// </summary>

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
        /// <summary>
        ///     This method confirms if the CalculateThePerimeterOfACircle methjod is working correctly
        /// </summary>

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
        /// <summary>
        ///     This method tests the negative scenario of the CalculateThePerimeterOfACircle method 
        /// </summary>

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
        /// <summary>
        ///     This method checks the correct format for the radius for the CalculateThePerimeterOfACircle method.
        /// </summary>

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