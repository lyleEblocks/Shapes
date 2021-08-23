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
using SquareShape;

namespace SquareTests
{
    /// <summary>
    ///     This Class provide tests for both the negative, positive and exception cases for the methods in the Square.cs class
    /// </summary>
  
    public class SquareTest
    {
        /// <summary>
        ///     The following test checks if two squares are equall.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Squares_Are_Equal()
        {
            //  Arrange
            Square squareA = new Square(10);
          
            Square squareB = new Square(10);

            //  Act
            bool result = squareA.Equals(squareB);

            //  Assert
            Assert.True(result);
        }

        /// <summary>
        ///     The following test checks the negative case if the squares are not equal.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Square_Are_NotEqual()
        {
            //  Arrange
            Square squareA = new Square(11);

            Square squareB = new Square(10);

            //  Act
            bool result = squareA.Equals(squareB);

            //  Assert
            Assert.False(result);
        }
        
        /// <summary>
        ///     The following test checks if the area of a square is calculated succesfully
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Square_Successfully()
        {
            // Arrange
            Square sq = new Square(10);

            // Act
            double result = sq.CalculateAreaOfaSquare();

            // Assert
            Assert.True(result == 100);
        }
        /// <summary>
        ///     This confirms the negative scenario of the CalculateAreaOfaSquare method
        /// </summary>

        [Fact]
        public void Calculate_Area_Of_Square_Unsuccessfully()
        {
            // Arrange
            Square sq = new Square(10);

            // Act
            double result = sq.CalculateAreaOfaSquare();

            // Assert
            Assert.False(result == 10);
        }
        /// <summary>
        ///     This method confirms the positive scenario of th CalculatePerimeterOfaSquare mewthod
        /// </summary>

        [Fact]
        public void Calculate_The_Perimeter_Of_a_Square_Successfully()
        {
            // Arrange
            Square sq = new Square(10);

            // Act
            double result = sq.CalculatePerimeterOfaSquare();

            // Assert
            Assert.True(result == 40);
        }
        /// <summary>
        ///     THis methods checks the negative scenario condition for the CalculatePerimeterOfaSquare method
        /// </summary>

        [Fact]
        public void Calculate_The_Perimeter_Of_a_Square_Unsuccessfully()
        {
            // Arrange
            Square sq = new Square(10);

            // Act
            double result = sq.CalculatePerimeterOfaSquare();

            // Assert
            Assert.False(result == 30);
        }
        /// <summary>
        ///     This method tests for a negative number entered in for the side variable.
        /// </summary>

        [Fact]
        public void Catch_Exception_Of_Square_Successfully()
        {
            // Arrange

            // Act
            
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
               Square square = new Square(-11); 
            });            
            
        }
    }

}