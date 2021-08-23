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
    ///     Provides Testing for the <see cref="Square"> Class.
    /// </summary>
    public class SquareTests
    {
        /// <summary>
        ///     Tests that two squares are equal successfully.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Squares_Are_Equal()
        {
            //Arrange
            Square square1 = new Square(12);
            Square square2 = new Square(12);

            //Act
            bool squares_are_equal = square1.Equals(square2);

            //Arrange
            Assert.True(squares_are_equal);
        }

        /// <summary>
        ///     Tests that two squares are not equal successfully.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Squares_Are_NotEqual()
        {
            //  Arrange
            Square square1 = new Square(15);
            Square square2 = new Square(11);

            //  Act
            bool result = square1.Equals(square2);

            //  Assert
            Assert.False(result);
        }

        /// <summary>
        ///     Test that an exception is thrown when an invalid parameters is passed.
        /// </summary>
        [Fact]
        public void Should_Ensure_Square_Has_Valid_Parameters()
        {
            //  Arrange
            //  Act
            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Square square1 = new Square(-11);
            });          
        }

        /// <summary>
        ///     Tests that the area of the square is calculated successfully.
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Square_Successfully()
        {
            // Arrange
            Square square = new Square(12);

            // Act
            double result = square.CalculateArea();

            // Assert
            Assert.Equal(144, result);
        }

        /// <summary>
        ///     Throws an exception when the square has invalid parameters.
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Square_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
               Square square = new Square(-11); 
            });
        }

        /// <summary>
        ///     Tests that the perimeter of the square is calculated successfully.
        /// </summary>
        [Fact]
        public void Calculate_Perimeter_Of_Square()
        {
            //Arrange
            Square square = new Square(12);
            //Act
            double result = square.CalculatePerimeter();
            //Assert
            Assert.Equal(48, result);
        }

        
    }
}