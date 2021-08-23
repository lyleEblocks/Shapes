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
    ///     This test class will test the Square class Methods.
    /// </summary>
    public class SquareTests 
    {
        [Fact]
        /// <summary>
        ///     Tests that a new square is instantiated successfully.
        /// </summary>
        public void Should_Instantiate_Square_Successfully()
        {
            // Arrange 
            // Act
            Square square = new Square(5);

            // Assert
            Assert.NotNull(square);
        }

        [Fact]
        /// <summary>
        ///     Tests that two squares are equal.
        /// </summary>
        public void Should_Ensure_Two_Squares_Are_Equal()
        {
            // Arrange
            Square squareA = new Square(5);
            Square squareB = new Square(5);

            // Act
            bool result = squareA.Equals(squareB);

            // Assert
            Assert.True(result);
        }

        [Fact]
        /// <summary>
        ///     Tests that two squares are not equal.
        /// </summary>
        public void Should_Ensure_Two_Squares_Are_Not_Equal()
        {
            // Arrange
            Square squareA = new Square(5);
            Square squareB = new Square(10);

            // Act
            bool result = squareA.Equals(squareB);

            // Assert
            Assert.False(result);
        }

        [Fact]
        /// <summary>
        ///     Tests that the exception <see cref="ArgumentOutOfRangeException" /> is thrown when the parameters are invalid
        /// </summary>
        public void Should_Ensure_Constructor_Parameters_Are_Valid_Throws_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { 
                Square square = new Square(-5); 
            });
        }

        [Fact]
        /// <summary>
        ///     Tests that the area is calculated successfully.
        /// </summary>
        public void Should_Ensure_Calculate_Area_Successfully()
        {
            // Arrange
            Square square = new Square(5);
            double expected = 5 * 5;

            // Act
            double result = square.CalculateArea();

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        /// <summary>
        ///     Tests that an <see cref="OverflowException" /> exception is thrown when the length is too large to calculate the area.
        /// </summary>
        public void Should_Ensure_Calculate_Area_Throws_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<OverflowException>(() => {
                Square square = new Square(double.MaxValue);
                square.CalculateArea();
            });

        }

        [Fact]
        /// <summary>
        ///     Tests that the perimeter is calculated successfully.
        /// </summary>
        public void Should_Ensure_Calculate_Perimeter_Successfully()
        {
            // Arrange
            Square square = new Square(5);
            double expected = 20;

            // Act
            double result = square.CalculatePerimeter();

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        /// <summary>
        ///     Tests that an <see cref="OverflowException" /> exception is thrown when the length is too large to calculate the perimeter.
        /// </summary>
        public void Should_Ensure_Calculate_Perimeter_Throws_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<OverflowException>(() => {
                Square square = new Square(double.MaxValue);
                square.CalculatePerimeter();
            });

        }

    }
}