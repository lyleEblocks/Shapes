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

namespace Shape
{
    /// <summary>
    ///     This class will test our Square class.
    /// </summary>
    public class SquareTests
    {   
        /// <summary>
        ///     This method will test that two squares are equal.
        /// </summary>
        [Fact]
        public void Should_Ensure_Two_Squares_Are_Equal()
        {
            // Arrange
            Square squareA = new Square(6);
            Square squareB = new Square(6);
            
            // Act
            bool result = squareA.Equals(squareB);

            // Assert
            Assert.True(result);
        }

        /// <summary>
        ///     This method will test that two squares are not equal.
        /// </summary>
        [Fact]
        public void Should_Ensure_Two_Squares_Not_Equal()
        {
            //Arrange
            Square squareA = new Square(5);
            Square squareB = new Square(7);

            //Act
            bool result = squareA.Equals(squareB);

            //Assert
            Assert.False(result);
        }
        
        /// <summary>
        ///     This method will test that an exception is thrown when the dimension of a square is negative or zero.
        /// </summary>
        [Fact]
        public void Should_Throw_Exception_When_Dimension_Zero_Or_Negative()
        {
            //Arrange
            
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Square squareA = new Square(-1);
            });
        }

        /// <summary>
        ///     This method will test that the area of a square is calculated successfully.
        /// </summary>
        [Fact]
        public void Should_Calculate_Area_Of_Square_Successfully()
        {
            //Arrange
            Square squareA = new Square(6);
            int expectedResult = 36;

            //Act
            int result = squareA.CalculateArea();

            //Assert
            Assert.Equal(expectedResult, result);         
        }

        /// <summary>
        ///    This method will test that the perimeter of a square is calculated successfully. 
        /// </summary>
        [Fact]
        public void Should_Calculate_Perimeter_Of_Square_Successfully()
        {
            //Arrange
            Square squareA = new Square(6);
            int expectedResult = 24;

            //Act
            int result = squareA.CalculatePerimeter();

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
