/*
 * [2019] - [2021] Eblocks Software (Pty) Ltd, All Rights Reserved.
 * NOTICE: All information contained herein is, and remains the property of Eblocks
 * Software (Pty) Ltd.
 * and its suppliers (if any). The intellectual and technical concepts contained herein
 * are proprietary
 * to Eblocks Software (Pty) Ltd. and its suppliers (if any) and may be covered by South 
 * African, U.S.
 * and Foreign patents, patents in process, and are protected by trade secret and / or 
 * copyright law.
 * Dissemination of this information or reproduction of this material is forbidden unless
 * prior written
 * permission is obtained from Eblocks Software (Pty) Ltd.
*/

using System;
using Xunit;

namespace Shape.Tests
{   
    /// <summary>
    ///     Provides <see cref="RectangleTests"/> test for Rectangle.cs.
    /// </summary>
    public class RectangleTests
    {   
        /// <summary>
        ///     Test case ,testing if two rectangels are equal.
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
        ///     Test case ,testing if two rectangels are not equal.
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
        ///     Test case ,testing to see if expection is thrown upon negative number entry.
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
        ///     Test case ,testing if area of rectangle is calculated Successfully.
        /// </summary>
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
        /// <summary>
        ///     Test case ,testing if area of rectangle is calculated incorrectly.
        /// </summary>
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
        /// <summary>
        ///      Test case, testing to see if expection is throw upon negative number entry.
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
        ///      Test case, testing to see if calculation of circumfrance is correct and successful.
        /// </summary>
        [Fact]
        public void Calculate_Circumfrance_of_A_Circle_Successfully()
        {
            // Arrange
            Circle circumf = new Circle(5);
            // Act
            double result = circumf.CalculateCircum();
            // Assert
           Assert.Equal(31.41592653589793, result);
            
        }
        /// <summary>
        ///  Test case, testing to see if calculation of circumfrance is incorrect .
        /// </summary>
        [Fact]
        public void Calculate_Circumfrance_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle circumf = new Circle(-5);});
        }
        /// <summary>
        ///      Test case, testing to see if calculation of area is correct and successful.
        /// </summary>
        [Fact]
        public void Calculate_Area_of_A_Circle_Successfully()
        {
            // Arrange
            Circle area = new Circle(5);
            // Act
            double result = area.Calculate_Area_Of_Circle();
            // Assert
            Assert.Equal(78.53981633974483, result);    
        }
        /// <summary>
        ///      Test case, testing to see if calculation of area is incorrect.
        /// </summary>
        [Fact]
        public void Calculate_Area_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle area = new Circle(-5);});
        }
        /// <summary>
        ///      Test case, testing to see if calculation of diameter is correct and successful.
        /// </summary>
        [Fact]
        public void Calculate_Diameter_of_A_Circle_Successfully()
        {
            // Arrange
            Circle diameter = new Circle(5);
            // Act
            double result = diameter.Calculate_Diameter_Of_Circle();
            // Assert
            Assert.Equal( 10 ,result);
        }
        /// <summary>
        ///      Test case, testing to see if calculation of diameter is incorrect.
        /// </summary>
        [Fact]
        public void Calculate_Diameter_of_A_Circle_Unsuccessfully()
        {
            // Arrange
            // Arrange
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> 
            { Circle diameter = new Circle(-5);});
        }
        /// <summary>
        ///      Test case, testing to see if calculation of area is correct and successful.
        /// </summary>
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
        /// <summary>
        ///      Test case, testing to see if calculation of area is incorrect.
        /// </summary>
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
        /// <summary>
        ///      Test case, testing to see if calculation of parameter is correct and successful.
        /// </summary>
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
        /// <summary>
        ///      Test case, testing to see if calculation of parameter is incorrect .
        /// </summary>
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
        /// <summary>
        ///     Test case, testing to see if Calculation of diagonal is correct and successful.
        /// </summary>
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
        /// <summary>
        ///     Test case, testing to see if Calculation of diagonal is incorrect.
        /// </summary>
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