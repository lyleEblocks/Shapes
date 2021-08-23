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
    ///     Tests the functionality of the <see cref="Rectangle"> class.
    /// </summary>
    public class RectangleTests
    {
        /// <summary>
        ///     Tests that the rectangles are equal successfully.
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
        ///     Tests that two rectangles are not equal successfully.
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
        ///     Tests that a rectangle has valid parameters successfully.
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
        ///     Tests that the calculation of the area of the rectangle is successful.
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Rectangle_Successfully()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(10,11);

            // Act
            double result = rectangle.CalculateArea();

            // Assert
            Assert.Equal(110, result);
        }

        /// <summary>
        ///     Tests that an exception is thrown if the area is calculated unsuccessfully. 
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
    }
}
